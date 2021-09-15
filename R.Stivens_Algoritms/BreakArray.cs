namespace R.Stivens_Algoritms
{
    //Массив массивов с разрывом (динамический) на связанных списках
    public class BreakArray
    {
        private ArrayRow _arrayRow;

        public bool TryGetValue(int rowNumber, int colNumber, out string value)
        {
            ArrayRow row = FindRow(rowNumber, _arrayRow);
            if(row == null)
            {
                value = null;
                return false;
            }
            ArrayColumn column = FindColumn(colNumber, row);
            if(column?.Value == null)
            {
                value = null;
                return false;
            }
            else
            {
                value = column.Value;
                return true;
            }
        }

        public void SetValue(int rowNumber, int colNumber, string value)
        {
            if(_arrayRow is null)
                _arrayRow = new ArrayRow { Number = rowNumber };

            ArrayRow row = FindRow(rowNumber, _arrayRow);
            row ??= AddNewRow(rowNumber, _arrayRow);

            if(row.Column is null)
                row.Column = new ArrayColumn { Number = colNumber };

            ArrayColumn column = FindColumn(colNumber, row);
            column ??= AddNewColumn(colNumber, row);
            column.Value = value;
        }

        private static ArrayColumn AddNewColumn(int columnNumber, ArrayRow arrayRow)
        {
            if(arrayRow.Column.Number > columnNumber)
                return AddToBegin(arrayRow.Column, columnNumber);

            ArrayColumn column = FindColumnBefore(columnNumber, arrayRow.Column);
            return AddNextTo(column, columnNumber);
        }

        private static ArrayColumn AddToBegin(ArrayColumn begin, int colnumber)
        {
            ArrayColumn old = begin;
            begin = new ArrayColumn{ Number = colnumber };
            begin.Next = old;
            return begin;
        }

        private static ArrayRow AddNewRow(int rowNumber, ArrayRow arrayRow)
        {
            if(arrayRow is null)
            {
                arrayRow = new ArrayRow { Number = rowNumber };
                return arrayRow;
            }

            if(arrayRow.Number > rowNumber)
                return AddToBegin(arrayRow, rowNumber);

            ArrayRow row = FindRowBefore(rowNumber, arrayRow);
            return AddNextTo(row, rowNumber);
        }

        private static ArrayColumn FindColumnBefore(int columnNumber, ArrayColumn arrayColumn)
        {
            ArrayColumn current = arrayColumn;
            while(current.Next is not null && current.Next.Number < columnNumber)
                current = current.Next;
            return current;
        }

        private static ArrayRow FindRowBefore(int rowNumber, ArrayRow arrayRow)
        {
            ArrayRow current = arrayRow;
            while(current.Next != null && current.Next.Number < rowNumber)
                current = current.Next;
            return current;
        }

        private static ArrayRow AddToBegin(ArrayRow begin, int rowNumber)
        {
            ArrayRow oldRow = begin;
            begin = new ArrayRow { Number = rowNumber };
            begin.Next = oldRow;
            return begin;
        }

        private static ArrayColumn AddNextTo(ArrayColumn column, int columnNumber)
        {
            ArrayColumn next = column.Next;
            column.Next = new ArrayColumn { Number = columnNumber };
            column.Next.Next = next;
            return column.Next;
        }

        private static ArrayRow AddNextTo(ArrayRow row, int rowNumber)
        {
            ArrayRow next = row.Next;
            row.Next = new ArrayRow { Number = rowNumber };
            row.Next.Next = next;
            return row.Next;
        }

        private static ArrayRow FindRow(int rowNumber, ArrayRow arrayRow)
        {
            ArrayRow current = arrayRow;

            while(current != null)
            {
                if(current.Number == rowNumber)
                    return current;
                current = current.Next;
            }
            return current;
        }

        private static ArrayColumn FindColumn(int columnNumber, ArrayRow arrayRow)
        {
            ArrayColumn current = arrayRow.Column;

            while(current != null)
            {
                if(current.Number == columnNumber)
                    return current;
                current = current.Next;
            }
            return current;
        }
    }

    public class ArrayRow
    {
        public int Number { get; init; }
        public ArrayRow Next { get; internal set; }
        public ArrayColumn Column { get; internal set;}
    }

    public class ArrayColumn
    {
        public int Number { get; init; }
        public string Value { get; internal set; }
        public ArrayColumn Next { get; internal set; }
    }
}
