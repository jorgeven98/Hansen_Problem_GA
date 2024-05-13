import os
from multiprocessing import Pool
import numpy as np
from math import *
from Utils.HansenFuncs import *

import plotly
import plotly.graph_objects as go
from IPython.display import display, HTML
from skimage import exposure


plotly.offline.init_notebook_mode()
display(HTML(
    '<script type="text/javascript" async src="https://cdnjs.cloudflare.com/ajax/libs/mathjax/2.7.1/MathJax.js?config=TeX-MML-AM_SVG"></script>'
))

from pythonnet import set_runtime
from clr_loader import get_coreclr


librarie_path = r"Your global path to GeometricAlgebraFulcrumLib-main"
runtime_config_folder = librarie_path + r"\GeometricAlgebraFulcrumLib-main\GeometricAlgebraFulcrumLib\GeometricAlgebraFulcrumLib.Lite\out_path"

try:
    rt = get_coreclr(runtime_config = runtime_config_folder + r"\GeometricAlgebraFulcrumLib.Lite.runtimeconfig.json")
    set_runtime(rt)
except:
    pass

import clr
import sys

sys.path.append(runtime_config_folder)

clr.FindAssembly("GeometricAlgebraFulcrumLib.Lite")
clr.AddReference("GeometricAlgebraFulcrumLib.Lite")

from GeometricAlgebraFulcrumLib.Lite.Samples.Geometry import HansenData2D
from GeometricAlgebraFulcrumLib.Lite.LinearAlgebra.Vectors.Space2D import Float64Vector2D



class HansenAnalysis:
    
    def __init__(self, grid_max, grid_steps, std_it, A, B, P0, std):
        
        self.grid = np.linspace(-grid_max, grid_max, grid_steps + 1)
        self.data = np.zeros((len(self.grid), len(self.grid)))
        self.out = np.zeros(std_it)
        self.std_it = std_it
        
        self.points = [(i, j, x, y) for i, x in enumerate(self.grid) for j, y in enumerate(self.grid)]
        
        self.A = A
        self.B = B
        self.P1 = P0
        self.std = std

    def Start(self, method):

        if method == "VGA":
            f = CalcErrorVGA
        elif method == "Tri":
            f = CalcErrorTri
        elif method == "Comp":
            f = CalcErrorComp
        elif method == "CGA":
            f = CalcErrorCGA
        elif method == "D":
            f = MetricD
        else:
            print("|||| No valid Method ||||")
            print("Options: \"VGA\"(Vector Geometric Algebra), \"CGA\"(Conformal Geometric Algebra), \"Tri\"(Trigonometric), \"Comp\"(Complex numbers), \"D\"(Metric D)")
            return None
        
        print("Start")
        with Pool() as pool:
            results = pool.starmap(f, [(self.A, self.B, self.P1, self.std, self.std_it, self.out, point) for point in self.points]) 
        print("Finish")
        
        for result in results:
            i, j, out = result
            self.data[i, j] = out
            
        return self.data
    
    def CalcError(self, A, B, P0, P, std):

        point = (1,1,P[0],P[1])
        result = self.__CalcError(A, B, P0, std, self.std_it, self.out, point)
        return result
    

def CalcErrorVGA(A, B, P1, std, std_it, out, point):
    
    i, j, x, y = point
    P = [x, y] 
            
    for k in range(std_it):
        hansen = HansenData2D.Create(vec2D(A),vec2D(B),vec2D(P1),vec2D(P))
        hansen = hansen.AddGNoise(std*pi/180)
        _, _, P2X, P2Y = hansen.SolveUsingVGa()

        out[k] = sqrt((P2X - P[0])**2 + (P2Y - P[1])**2)
    
    return (i, j, np.std(out))

def CalcErrorCGA(A, B, P1, std, std_it, out, point):
    
    i, j, x, y = point
    P = [x, y] 
            
    for k in range(std_it):
        hansen = HansenData2D.Create(vec2D(A),vec2D(B),vec2D(P1),vec2D(P))
        hansen = hansen.AddGNoise(std*pi/180)
        try:
            _, _, P2X, P2Y = hansen.SolveUsingCGa()
            out[k] = sqrt((P2X - P[0])**2 + (P2Y - P[1])**2)
            
            if isnan(P2X) or isinf(P2X):
                out[k] = 0
        except:
            out[k] = 0
    
    return (i, j, np.std(out))


def CalcErrorTri(A, B, P1, std, std_it, out, point):
    
    i, j, x, y = point
    P = [x, y] 
            
    for k in range(std_it):
        hansen = HansenData2D.Create(vec2D(A),vec2D(B),vec2D(P1),vec2D(P))
        hansen = hansen.AddGNoise(std*pi/180)
        try:
            _, _, P2X, P2Y = hansen.SolveUsingTrig()
            out[k] = sqrt((P2X - P[0])**2 + (P2Y - P[1])**2)
            
            if isnan(P2X) or isinf(P2X):
                out[k] = 0
        except:
            out[k] = 0
    
    return (i, j, np.std(out))

def CalcErrorComp(A, B, P1, std, std_it, out, point):
    
    i, j, x, y = point
    P = [x, y] 
            
    for k in range(std_it):
        hansen = HansenData2D.Create(vec2D(A),vec2D(B),vec2D(P1),vec2D(P))
        hansen = hansen.AddGNoise(std*pi/180)
        _, _, P2X, P2Y = hansen.SolveUsingComplex()

        out[k] = sqrt((P2X - P[0])**2 + (P2Y - P[1])**2)
    
    return (i, j, np.std(out))

def MetricD(A, B, P1, std, std_it, out, point):
    i, j, x, y = point
    P = [x, y]
    
    for k in range(std_it):
        hansen = HansenData2D.Create(vec2D(A),vec2D(B),vec2D(P1),vec2D(P))
        hansen = hansen.AddGNoise(std*pi/180)
        b1 = hansen.Alpha1.Radians.Value
        b2 = hansen.Beta1.Radians.Value
        
        b1 = dist_to_zero_or_pi(b1)
        b2 = dist_to_zero_or_pi(b2)
            
        out[k] = 1/min(b1,b2)
        
    return(i, j, np.mean(out))
    

def roundToVar(valor_entrada, valor_salida):
    # Determining the number of decimal places of the input value
    num_decimales = len(str(valor_entrada).split('.')[1]) if '.' in str(valor_entrada) else 0

    # Round the output value to the same number of decimal places as the input value.
    valor_salida_redondeado = round(valor_salida, num_decimales)

    return valor_salida_redondeado
        
def dist_to_zero_or_pi(theta):
    # Calculate the remainder of theta with respect to pi
    res = theta % np.pi
    # Return the smallest distance to 0 or pi using min
    return min(res, np.pi - res)
        
def PlotHansenHeatMap(data, hansen, eq_val = 1000, colormap = "Turbo", colorbarY = -0.35, save_path = ""):
    x, y = np.meshgrid(hansen.grid, hansen.grid)
    min_val, max_val = np.min(data), np.max(data)
    data_eq = exposure.equalize_hist(data, eq_val)
    #data_eq = data
    
    fig = go.Figure(data=go.Heatmap(x=x[0], y=y[:,0][::-1], z=np.flipud(data_eq.T), 
                                colorscale=colormap,  #Turbo, Viridis
                                colorbar=dict(x=0.5, # Position of the colour bar on the X-axis (0.5 to centre)
                                        xanchor='center',
                                        y=colorbarY, # Position of the colour bar on the Y-axis
                                        len=1, # Length of the colour bar
                                        orientation='h', # Horizontal
                                        outlinewidth=1,
                                        tickvals = [data_eq.min(), data_eq.max()],
                                        ticktext = ["%.1e"%(min_val),"%.1e"%(max_val)],
                                        tickfont = dict(family = "Latin Modern", size=60)
                                        )))

    fig.add_shape(
            # Line with reference to the plot
                type="rect",
                xref="paper",
                yref="paper",
                x0=0,
                y0=0,
                x1=1.0,
                y1=1.0,
                line=dict(
                    color="black",
                    width=2,
                )
            )

    # Adding points A, B, C
    fig.add_trace(go.Scatter(x=[hansen.A[0], hansen.B[0], hansen.P1[0]], y=[hansen.A[1], hansen.B[1], hansen.P1[1]], 
                            mode='markers', 
                            marker=dict(color='black', size=10, line=dict(color='white', width=2))))
    
    fig.add_annotation(x=hansen.A[0], y=hansen.A[1], text="$\\Large \\textbf{A}$", showarrow=False, font=dict(size=28, color='white'), xshift=0, yshift=30)
    fig.add_annotation(x=hansen.B[0], y=hansen.B[1], text="$\\Large \\textbf{B}$", showarrow=False, font=dict(size=28, color='white'), xshift=0, yshift=30)
    fig.add_annotation(x=hansen.P1[0], y=hansen.P1[1], text="$\\Large \\textbf{P1}$", showarrow=False, font=dict(size=28, color='white'), xshift=0, yshift=30)

    # Adjusting the layout
    fig.update_layout(xaxis_title=dict(text='<i>x (m)</i>', font=dict(family = "Latin Modern", size = 70)),
                    yaxis_title=dict(text='<i>y (m)</i>', font=dict(family = "Latin Modern", size = 70)),
                    xaxis=dict(tickvals=[-2, -1, 0, 1, 2], ticktext = [-2, -1, 0, 1, 2]),
                    yaxis=dict(tickvals=[-2, -1, 0, 1, 2], ticktext = [-2, -1, 0, 1, 2]),
                    plot_bgcolor='white',
                    margin=dict(t=50, l=150, r=100, b=100, pad=10),
                    font = dict(family = "Latin Modern", size = 50),
                    width=1080,
                    height=1080)
    
    

    if save_path != "":
        if not os.path.exists("images"):
            os.mkdir("images")
        fig.write_image(save_path)
    
    # Showing the graph
    fig.show()
    
    