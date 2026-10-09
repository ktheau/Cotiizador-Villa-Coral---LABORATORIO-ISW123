namespace Cotiizador_Villa_Coral
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Kimberly_Load(object sender, EventArgs e)
        {

        }

        private void btnImperativo_Click(object sender, EventArgs e)
        {
            //Mision 1 * IMPERATIVO: LA RECETA,

            string nombre = txtHuesped.Text;
            int noches = (int)nudNoches.Value;
            decimal tarifa = Convert.ToDecimal(nudTarifa.Value);


            decimal subtotal = noches * tarifa;
            decimal descuento = 0m;
            if (noches >= 7)
            {
                descuento = subtotal * 0.10m;

            }

            decimal baseImponible = subtotal - descuento;
            decimal itbis = baseImponible * 0.18m;
            decimal servicio = baseImponible * 0.10m;
            decimal total = baseImponible + itbis + servicio;

            lstResultados.Items.Add($"{nombre}: US$ {total:N2}");
            lbl_ITBIS.Text = $"US$ {itbis:N2}";
            lbl_Servicio.Text = $"US$ {servicio:N2}";
            lbl_Subtotal.Text = $"US$ {subtotal:N2}";
            lbl_Total.Text = $"US$ {total:N2}";
            lbl_Descuento.Text = $"US$ {descuento:N2}";
            

            ;
        }
    }
}
