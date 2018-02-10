namespace Calculator
{
    interface InterfaceCalc
    {
        double MemoryShow(); //показать содержимое регистра памяти
        void Memory_Clear(); //стереть содержимое регистра памяти

        //* / + - к регистру памяти
        void M_Multiplication(double b);
        void M_Division(double b);
        void M_Sum(double b);
        void M_Subtraction(double b); //вычитание
    }
}
