namespace Calc4GH
{
    public partial class Form1 : Form
    {
        // Bufor do przechowywania pierwszej liczby
        float buffer = 0;
        // Zmienna do przechowywania oczekuj¹cej operacji
        char operation = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            // Dodaje cyfrê do wyœwietlacza po naciœniêciu przycisku z numerem
            int number = int.Parse(((Button)sender).Text);
            displayTextBox.Text += number;
        }

        private void ClearDisplay(object sender, EventArgs e)
        {
            // Czyœci wyœwietlacz i resetuje bufor oraz operacjê
            displayTextBox.Text = String.Empty;
            buffer = 0;
            operation = ' ';
        }

        private void FunctionButtonPressed(object sender, EventArgs e)
        {
            // Sprawdza, czy na wyœwietlaczu jest liczba, któr¹ mo¿na przetworzyæ
            if (!float.TryParse(displayTextBox.Text, out float currentValue))
                return; // WyjdŸ, jeœli wyœwietlacz nie zawiera poprawnej liczby

            if (operation == ' ')
            {
                // Przechowuje bie¿¹c¹ wartoœæ wyœwietlacza w buforze
                buffer = currentValue;
                // Czyœci wyœwietlacz
                displayTextBox.Text = String.Empty;
                // Ustawia operacjê na wybrany operator
                operation = ((Button)sender).Text[0];
            }
            else
            {
                // Wykonuje oczekuj¹c¹ operacjê na bie¿¹cej wartoœci
                buffer = PerformOperation(buffer, currentValue, operation);
                // Wyœwietla wynik
                displayTextBox.Text = buffer.ToString();
                // Ustawia operacjê na nowy operator
                operation = ((Button)sender).Text[0];
            }
        }

        private void ShowResult(object sender, EventArgs e)
        {
            // Sprawdza, czy na wyœwietlaczu jest liczba, któr¹ mo¿na przetworzyæ
            if (!float.TryParse(displayTextBox.Text, out float currentValue))
                return; // WyjdŸ, jeœli wyœwietlacz nie zawiera poprawnej liczby

            // Wykonuje ostatni¹ operacjê i wyœwietla wynik
            buffer = PerformOperation(buffer, currentValue, operation);
            displayTextBox.Text = buffer.ToString();
            // Resetuje operacjê, aby wskazaæ brak oczekuj¹cej operacji
            operation = ' ';
        }

        private float PerformOperation(float left, float right, char op)
        {
            // Wykonuje operacjê arytmetyczn¹ w zale¿noœci od operatora
            switch (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/': return right != 0 ? left / right : 0; // Obs³uguje dzielenie przez zero
                default: return right;
            }
        }

        // Przypisz ClearDisplay do zdarzenia Click przycisku czyszczenia
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearDisplay(sender, e);
        }

        // Przypisz FunctionButtonPressed do zdarzeñ Click przycisków operatorów ( +, -, *, / )
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FunctionButtonPressed(sender, e);
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            FunctionButtonPressed(sender, e);
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            FunctionButtonPressed(sender, e);
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            FunctionButtonPressed(sender, e);
        }

        // Przypisz ShowResult do zdarzenia Click przycisku równoœci (=)
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            ShowResult(sender, e);
        }
    }
}
