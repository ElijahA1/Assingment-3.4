using Assingment_3._4.Data;

namespace Assingment_3._4
{
    public partial class Form1 : Form
    {
 
        public Form1()
        {
            InitializeComponent();

            bindingSource3.DataSource = DataSources.GetOrders();
            
        }
    }
}
