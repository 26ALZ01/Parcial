//📘 Parcial II – Forma B
//Ejercicio1
private void btnCalcular_Click(object sender, EventArgs e)
{
    double precio1 = Convert.ToDouble(txtPrecio1.Text);
    double precio2 = Convert.ToDouble(txtPrecio2.Text);
    double precio3 = Convert.ToDouble(txtPrecio3.Text);

    double promedio = (precio1 + precio2 + precio3) / 3;

    lblResultado.Text = "El precio medio del producto es de " + promedio.ToString("F2") + " quetzales";
}


//Ejercicio2
private void btnCalcularMonto_Click(object sender, EventArgs e)
{
    int dias = Convert.ToInt32(txtDias.Text);
    double kilometros = Convert.ToDouble(txtKilometros.Text);

    double tarifaDia = 200;      // Q200 por día
    double tarifaKm = 5;         // Q5 por kilómetro

    double montoTotal = (dias * tarifaDia) + (kilometros * tarifaKm);

    lblMonto.Text = "Monto total: Q" + montoTotal.ToString("F2");
}

