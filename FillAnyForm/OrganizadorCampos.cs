using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FillAnyForm
{
    public partial class OrganizadorCampos : Form
    {
        List<string> list;

        public OrganizadorCampos(List<string> myList)
        {
            InitializeComponent();
            list = myList;
        }

        private void OrganizadorCampos_Load(object sender, EventArgs e)
        {
            btnRecord.Visible = false;

            Height = Screen.PrimaryScreen.WorkingArea.Height;
            Width = 40 * Screen.PrimaryScreen.WorkingArea.Width / 100;
            Location = new Point(1000, 0);

            int y = 10;

            foreach (var item in list)
            {
                Label label = new Label();
                
                label.Text = item;
                label.Size = new Size(400, 30);
                
                label.Location = new Point(10, y);
                y += 40;
                label.BorderStyle = BorderStyle.FixedSingle;
                this.Controls.Add(label);
            }

            foreach (var item in Controls.OfType<Label>()) //https://www.youtube.com/watch?v=diI6WyeyCSU
                ControlExtension.Draggable(item, true);

            btnRecord.Visible = true;
            btnRecord.Location = new Point((Width-btnRecord.Width)/2, y+40);
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            List<DataClass> data = new List<DataClass>();

            FileStream fs = new FileStream("dados.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);

            DataClass dc = new DataClass();

            foreach (var item in Controls.OfType<Label>())
            {
                data.Add(new DataClass { text = item.Text, position = item.Location.Y });
            }

            var orderByPosition = data.OrderBy(x => x.position).ToList();

            foreach (var item in orderByPosition)
            {
                sw.WriteLine(item.text);
            }

            sw.Close();
            fs.Close();
        }
    }
}
