from math import *
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


class Hansen:
    
    def __init__(self, pointA, pointB, pointP1, pointP2):
        self.A = pointA
        self.B = pointB
        self.P1 = pointP1
        self.P2 = pointP2
        
        self.Data = HansenData2D.Create(vec2D(pointA), vec2D(pointB), vec2D(pointP1), vec2D(pointP2))
        
        self.Alpha1 = self.Data.Alpha1.Radians.Value
        self.Alpha2 = self.Data.Alpha2.Radians.Value
        self.Beta1 = self.Data.Beta1.Radians.Value
        self.Beta2 = self.Data.Beta2.Radians.Value
        
    def __str__(self):
        print(self.Data)
        return ""

    def Recreate(self, pointA, pointB, pointP1, pointP2):
        self.Data = HansenData2D.Create(vec2D(pointA), vec2D(pointB), vec2D(pointP1), vec2D(pointP2))
        
    def ActualizeData(self):
        self.Data = HansenData2D.Create(vec2D(self.A), vec2D(self.B), vec2D(self.P1), vec2D(self.P2))
    
    def AddGaussianNoise(self, stdDev):
        self.Data = self.Data.AddGNoise(stdDev*pi/180)
        
    def SolveGA(self):
        P1x, P1y, P2x, P2y = self.Data.SolveUsingVGa()
        return [P1x, P1y, P2x, P2y]
    
    def SolveCGA(self):
        P1x, P1y, P2x, P2y = self.Data.SolveUsingCGa()
        return [P1x, P1y, P2x, P2y]
    
    def SolveTrigonometric(self):
        P1x, P1y, P2x, P2y = self.Data.SolveUsingTrig()
        return [P1x, P1y, P2x, P2y]
    
    def SolveComplex(self):
        P1x, P1y, P2x, P2y = self.Data.SolveUsingComplex()
        return [P1x, P1y, P2x, P2y]
    
    def Angles(self, units):
        if units == "Radians":
            self.Alpha1 = self.Data.Alpha1.Radians.Value
            self.Alpha2 = self.Data.Alpha2.Radians.Value
            self.Beta1 = self.Data.Beta1.Radians.Value
            self.Beta2 = self.Data.Beta2.Radians.Value
        elif units == "Degrees":
            self.Alpha1 = self.Data.Alpha1.Degrees.Value
            self.Alpha2 = self.Data.Alpha2.Degrees.Value
            self.Beta1 = self.Data.Beta1.Degrees.Value
            self.Beta2 = self.Data.Beta2.Degrees.Value
        else:
            print("||ERROR|| Select units: \"Degrees\", \"Radians\"")
 
        
def vec2D(coord):
    vec = Float64Vector2D.Create(coord[0], coord[1])
    return vec



        