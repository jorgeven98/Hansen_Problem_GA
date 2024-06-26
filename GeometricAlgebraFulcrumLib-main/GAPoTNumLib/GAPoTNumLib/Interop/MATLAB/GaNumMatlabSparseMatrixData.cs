﻿using System;
using System.Diagnostics;

namespace GAPoTNumLib.Interop.MATLAB
{
    /// <summary>
    /// Used for exchanging sparse matrix data with MATLAB
    /// </summary>
    public sealed class GeoNumMatlabSparseMatrixData
    {
        public static GeoNumMatlabSparseMatrixData CreateMatrix(int rowsCount, int columnsCount, int[] rowIndicesArray, int[] columnIndicesArray, double[] valuesArray)
        {
            return new GeoNumMatlabSparseMatrixData(
                rowsCount,
                columnsCount,
                rowIndicesArray,
                columnIndicesArray,
                valuesArray
            );
        }

        public static GeoNumMatlabSparseMatrixData CreateMatrix(int rowsCount, int columnsCount, int itemsCount)
        {
            return new GeoNumMatlabSparseMatrixData(
                rowsCount,
                columnsCount,
                itemsCount
            );
        }

        public static GeoNumMatlabSparseMatrixData CreateColumnMatrix(int rowsCount, int itemsCount)
        {
            return new GeoNumMatlabSparseMatrixData(
                rowsCount,
                1,
                itemsCount
            );
        }

        public static GeoNumMatlabSparseMatrixData CreateRowMatrix(int columnsCount, int itemsCount)
        {
            return new GeoNumMatlabSparseMatrixData(
                1,
                columnsCount,
                itemsCount
            );
        }

        public static GeoNumMatlabSparseMatrixData CreateSquareMatrix(int rowsCount, int itemsCount)
        {
            return new GeoNumMatlabSparseMatrixData(
                rowsCount,
                rowsCount,
                itemsCount
            );
        }


        public int RowsCount { get; }

        public int ColumnsCount { get; }

        public int ItemsCount 
            => ValuesArray.Length;

        public int[] RowIndicesArray { get; }

        public int[] ColumnIndicesArray { get; }

        public double[] ValuesArray { get; }


        private GeoNumMatlabSparseMatrixData(int rowsCount, int columnsCount, int itemsCount)
        {
            if (rowsCount * columnsCount < itemsCount)
                throw new InvalidOperationException();

            RowsCount = rowsCount;
            ColumnsCount = columnsCount;
            RowIndicesArray = new int[itemsCount];
            ColumnIndicesArray = new int[itemsCount];
            ValuesArray = new double[itemsCount];
        }

        private GeoNumMatlabSparseMatrixData(int rowsCount, int columnsCount, int[] rowIndicesArray, int[] columnIndicesArray, double[] valuesArray)
        {
            if (rowsCount * columnsCount < rowIndicesArray.Length)
                throw new InvalidOperationException();

            if (rowIndicesArray.Length != valuesArray.Length)
                throw new InvalidOperationException();

            if (columnIndicesArray.Length != valuesArray.Length)
                throw new InvalidOperationException();

            RowsCount = rowsCount;
            ColumnsCount = columnsCount;
            RowIndicesArray = rowIndicesArray;
            ColumnIndicesArray = columnIndicesArray;
            ValuesArray = valuesArray;
        }


        public GeoNumMatlabSparseMatrixData SetItem(int sparseIndex, int row, int column, double value)
        {
            Debug.Assert(
                row >= 1 && row <= RowsCount, 
                $"Row number {row} outside valid range (1, {RowsCount})"
            );

            Debug.Assert(
                column >= 1 && column <= ColumnsCount, 
                $"Column number {column} outside valid range (1, {ColumnsCount})"
            );

            RowIndicesArray[sparseIndex] = row;
            ColumnIndicesArray[sparseIndex] = column;
            ValuesArray[sparseIndex] = value;

            return this;
        }

        public GeoNumMatlabSparseMatrixData SetItem(int sparseIndex, int itemIndex, double value)
        {
            if (RowsCount == 1)
            {
                Debug.Assert(itemIndex >= 1 && itemIndex <= ColumnsCount);

                RowIndicesArray[sparseIndex] = 1;
                ColumnIndicesArray[sparseIndex] = itemIndex;
            }
            else if (ColumnsCount == 1)
            {
                Debug.Assert(itemIndex >= 1 && itemIndex <= RowsCount);

                RowIndicesArray[sparseIndex] = itemIndex;
                ColumnIndicesArray[sparseIndex] = 1;
            }
            else
                throw new InvalidOperationException();

            ValuesArray[sparseIndex] = value;

            return this;
        }


        public double[,] GetArray()
        {
            var result = new double[RowsCount, ColumnsCount];

            for (var i = 0; i < ItemsCount; i++)
            {
                var row = RowIndicesArray[i] - 1;
                var col = ColumnIndicesArray[i] - 1;
                var value = ValuesArray[i];

                result[row, col] = value;
            }

            return result;
        }
    }
}