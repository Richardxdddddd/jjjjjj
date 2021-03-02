﻿using LaboratorioProgramacionUno.Dominio;
using LaboratorioProgramacionUno.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacionUno.Vista
{
    public partial class FrmOperaciones : Form
    {
        public FrmOperaciones()
        {
            InitializeComponent();
        }
        public String nombrePersona;
        private void FrmOperaciones_Load(object sender, EventArgs e)
        {
           
            lblMostrarUser.Text = nombrePersona;

            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MENOR o IGUAL 50 NO TENDRA DESCUENTO", "<=50");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 50 Y MENOR QUE 100 TENDRA UN DESUENTO DEL 0.05 ", ">50 and <100");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL A 100 O MENOR QUE 101 TENDRA UN DESUENTO DEL 0.10 ", ">= 100 and <101");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR o IGUAL 101 Y MENOR QUE 150 TENDRA UN DESUENTO DEL 0.20 ", ">101 and <150");
            dataGridView1.Rows.Add("SI EL PRODUCTO TIENE UN PRECIO MAYOR A 150 TENDRA UN DESUENTO DEL 0.50 ", ">150");

        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {

            {
                UsuarioOperaciones administrador = new UsuarioOperaciones();
                ClsOperacionUsuario cls1 = new ClsOperacionUsuario();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPproducto.Text);
                administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
                double resultado1 = cls1.ca1(administrador);
                lblTsinIva.Text = resultado1.ToString("0.00");
            }

            {
                UsuarioOperaciones administrador = new UsuarioOperaciones();
                ClsOperacionUsuario cls2 = new ClsOperacionUsuario();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPproducto.Text);
                administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
                administrador.Iva = Convert.ToDouble(value: txtIva.Text);
                double resultado1 = cls2.ca2(administrador);
                lblTotalIniacial.Text = resultado1.ToString("0.00");
            }
            {
                UsuarioOperaciones administrador = new UsuarioOperaciones();
                ClsOperacionUsuario cls3 = new ClsOperacionUsuario();

                administrador.NombreDelProducto = Convert.ToString(value: txtNproducto.Text);
                String resultado1 = cls3.ca3(administrador);
                lblNombreProducto.Text = resultado1.ToString();
            }
            {
                UsuarioOperaciones administrador = new UsuarioOperaciones();
                ClsOperacionUsuario cls4 = new ClsOperacionUsuario();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPproducto.Text);
                administrador.Iva = Convert.ToDouble(value: txtIva.Text);
                double resultado1 = cls4.ca4(administrador);
                lblIvaAgregar.Text = resultado1.ToString("0.00");
            }

            {
                UsuarioOperaciones administrador = new UsuarioOperaciones();
                ClsOperacionUsuario cls5 = new ClsOperacionUsuario();

                administrador.PrecioDelProducto = Convert.ToDouble(value: txtPproducto.Text);
                administrador.Cantidad = Convert.ToDouble(value: txtCantidad.Text);
                administrador.Iva = Convert.ToDouble(value: txtIva.Text);
                double resultado1 = cls5.ca2(administrador);

                if (resultado1 <= 50)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1);
                    lblTotalFinal.Text = totalFinal.ToString("0.00");

                }
                else if (resultado1 >= 50 && resultado1 < 100)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - 0.05;
                    lblTotalFinal.Text = totalFinal.ToString("0.00");

                }
                else if (resultado1 >= 100 && resultado1 < 101)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - 0.10;
                    lblTotalFinal.Text = totalFinal.ToString("0.00");
                }
                else if (resultado1 >= 101 && resultado1 < 150)
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - 0.20;
                    lblTotalFinal.Text = totalFinal.ToString("0.00");
                }
                else 
                {
                    double totalFinal;
                    totalFinal = Convert.ToDouble(resultado1) - 0.50;
                    lblTotalFinal.Text = totalFinal.ToString("0.00");

                }
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {
 
        }
    }
}
