namespace Calc4GH
{
    public partial class Form1 : Form
    {
        // Bufor do przechowywania pierwszej liczby
        float buffer = 0;
        // Zmienna do przechowywania oczekuj�cej operacji
        char operation = ' ';

        public Form1()
        {
            InitializeComponent();
        }

        private void ButtonPressed(object sender, EventArgs e)
        {
            // Dodaje cyfr� do wy�wietlacza po naci�ni�ciu przycisku z numerem
            int number = int.Parse(((Button)sender).Text);
            displayTextBox.Text += number;
        }

        private void ClearDisplay(object sender, EventArgs e)
        {
            // Czy�ci wy�wietlacz i resetuje bufor oraz operacj�
            displayTextBox.Text = String.Empty;
            buffer = 0;
            operation = ' ';
        }

        private void FunctionButtonPressed(object sender, EventArgs e)
        {
            // Sprawdza, czy na wy�wietlaczu jest liczba, kt�r� mo�na przetworzy�
            if (!float.TryParse(displayTextBox.Text, out float currentValue))
                return; // Wyjd�, je�li wy�wietlacz nie zawiera poprawnej liczby

            if (operation == ' ')
            {
                // Przechowuje bie��c� warto�� wy�wietlacza w buforze
                buffer = currentValue;
                // Czy�ci wy�wietlacz
                displayTextBox.Text = String.Empty;
                // Ustawia operacj� na wybrany operator
                operation = ((Button)sender).Text[0];
            }
            else
            {
                // Wykonuje oczekuj�c� operacj� na bie��cej warto�ci
                buffer = PerformOperation(buffer, currentValue, operation);
                // Wy�wietla wynik
                displayTextBox.Text = buffer.ToString();
                // Ustawia operacj� na nowy operator
                operation = ((Button)sender).Text[0];
            }
        }

        private void ShowResult(object sender, EventArgs e)
        {
            // Sprawdza, czy na wy�wietlaczu jest liczba, kt�r� mo�na przetworzy�
            if (!float.TryParse(displayTextBox.Text, out float currentValue))
                return; // Wyjd�, je�li wy�wietlacz nie zawiera poprawnej liczby

            // Wykonuje ostatni� operacj� i wy�wietla wynik
            buffer = PerformOperation(buffer, currentValue, operation);
            displayTextBox.Text = buffer.ToString();
            // Resetuje operacj�, aby wskaza� brak oczekuj�cej operacji
            operation = ' ';
        }

        private float PerformOperation(float left, float right, char op)
        {
            // Wykonuje operacj� arytmetyczn� w zale�no�ci od operatora
            switch (op)
            {
                case '+': return left + right;
                case '-': return left - right;
                case '*': return left * right;
                case '/': return right != 0 ? left / right : 0; // Obs�uguje dzielenie przez zero
                default: return right;
            }
        }

        // Przypisz ClearDisplay do zdarzenia Click przycisku czyszczenia
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearDisplay(sender, e);
        }

        // Przypisz FunctionButtonPressed do zdarze� Click przycisk�w operator�w ( +, -, *, / )
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

        // Przypisz ShowResult do zdarzenia Click przycisku r�wno�ci (=)
        private void buttonEquals_Click(object sender, EventArgs e)
        {
            ShowResult(sender, e);
        }
    }
}
