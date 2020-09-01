﻿using ClienteBankSWNet.controller;
using ClienteBankSWNet.ProductWebService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClienteBankSWNet.gui
{
    public partial class GUIAddProductRegistration : Form
    {
        private ProductController productController;
        private ProductRegistrationController productRegistrationController;

        public GUIAddProductRegistration()
        {
            InitializeComponent();

            this.productController = ProductController.Instance;
            this.productRegistrationController = ProductRegistrationController.Instance;

            loadProductCodes();
        }

        private void btnFindClient_Click(object sender, EventArgs e)
        {
            GUIModalListClients guiModal = new GUIModalListClients();
            guiModal.ShowDialog();
            txtClientId.Text = guiModal.ClientIdSelected;
        }

        private void btnAddProductRegistration_Click(object sender, EventArgs e)
        {
            String strClientId = txtClientId.Text;
            String strProductCode = comboBoxProductCode.SelectedItem.ToString();
            String strProductNumber = txtProductNumber.Text;
            String strBalance = txtBalance.Text;
            DateTime registrationDate = datePickerRegistration.Value;
            DateTime expirationDate = datePickerExpiration.Value;
            bool state = rbtnActivo.Checked;

            try
            {
                if (this.productRegistrationController.AddProductRegistration(strClientId, strProductCode, strProductNumber, 
                    strBalance, registrationDate, expirationDate, state))
                {
                    MessageBox.Show("El producto ha sido registrado correctamente.", "Producto Registrado");

                    txtClientId.Text = "";
                    comboBoxProductCode.SelectedItem = null;
                    txtProductNumber.Text = "";
                    txtBalance.Text = "";
                    datePickerRegistration.Value = DateTime.Today;
                    datePickerExpiration.Value = DateTime.Today;
                }
                else
                {
                    MessageBox.Show("No se ha podido hacer el registro del producto.", "Advertencia");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error!!!");
            }
        }

        private void loadProductCodes()
        {
            product[] products = productController.ListAllProducts();

            comboBoxProductCode.Items.Clear();
            for (int i = 0; i < products.Length; i++)
            {
                comboBoxProductCode.Items.Add(products[i].name);
            }
        }
    }
}
