//📘 Parcial II – Forma A
//Problema 1: Combustible total para flota vehicular
private void btnAceptar_Click(object sender, EventArgs e)
{
    int numTurismos = Convert.ToInt32(txtTurismos.Text);
    int numTodoterrenos = Convert.ToInt32(txtTodoterrenos.Text);

    double capacidadTurismos = Convert.ToDouble(txtCapacidadTurismos.Text);
    double capacidadTodoterrenos = Convert.ToDouble(txtCapacidadTodoterrenos.Text);

    double combustibleTotal = (numTurismos * capacidadTurismos) + (numTodoterrenos * capacidadTodoterrenos);

    lblResultado.Text = "Las necesidades totales de combustible son de " + combustibleTotal.ToString("F2") + " litros";
}

//Problema 2: Volumen de un cilindro
private void btnCalcularVolumen_Click(object sender, EventArgs e)
{
    double diametro = Convert.ToDouble(txtDiametro.Text);
    double altura = Convert.ToDouble(txtAltura.Text);

    double radio = diametro / 2;
    double volumen = Math.PI * Math.Pow(radio, 2) * altura;

    lblVolumen.Text = "El volumen del cilindro es de " + volumen.ToString("F6") + " m³";
}
