using System.Collections.Generic;
using System.Windows;

namespace CS101Review
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Get the text value from our name text box, store it in the name variable
            string name = txtName.Text;

            // Say hello
            MessageBox.Show("Hello, " + name);

            // Conditionals
            /*
            if (name == "Spongebob Squarepants")
            {
                // If they are spongebob...
                MessageBox.Show("I'm Ready!");
            }
            else if (name == "Jimmy Neutron")
            {
                // If they are jimmy...
                MessageBox.Show("Gotta Blast!");
            }
            else
            {
                // Anyone else does not matter
                MessageBox.Show("I don't really care about you");
            }
            */

            // Get the value from our age text box, converting it to an int
            int age = int.Parse(txtAge.Text);

            // Boolean logic
            /*
            if (age > 12 && age < 20)
            {
                // Age is between 13-19. Could also use (age >= 13 && age <= 19)
                MessageBox.Show("I don't like you, you're a teen");
            }

            if (age <= 5 || age >= 90)
            {
                // Age is 5 or younger, OR 90 or older
                MessageBox.Show("You are either too old or too young");
            }
            */

            // While loops
            /*
            int i = 0;
            while (i < 20)
            {
                MessageBox.Show("Am I annoying you yet?");
                i++;
            }
            */

            // Collections and For Loops
            /*
            List<string> messages = new List<string>(); // define the array

            messages.Add("You are cool"); // add elements to the array
            messages.Add("Happy birthday");
            messages.Add("I hope you have a good day");

            for (int j = 0; j < messages.Count; j++) // loop through the array
            {
                // show the messages from the array
                MessageBox.Show(messages[j]);
            }
            */

            // Methods
            /*
            ShowMessages("Top Message", "Bottom Message"); // call the function
            */
        }

        // Method definition
        public string ShowMessages(string message1, string message2)
        {
            string combinedMessage = message1 + "\n" + message2;
            MessageBox.Show(combinedMessage);
            return combinedMessage;
        }
    }
}
