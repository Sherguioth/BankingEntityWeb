/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import controller.ClientController;
import controller.ProductController;
import controller.ProductRegistrationController;

import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

/**
 *
 * @author Sherg
 */
public class GUIPrincipal extends javax.swing.JFrame {

    private final ClientController clientController;
    private final ProductController productController;
    private final ProductRegistrationController productRegistrationController;

    /**
     * Creates new form GUIPrincipal
     * @param model
     */

    public GUIPrincipal() {
        initComponents();
        imgeBank.setIcon(new ImageIcon("images/iconBank.png"));
        
        this.clientController = new ClientController();
        this.productController = new ProductController();
        this.productRegistrationController = new ProductRegistrationController();
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    private void initComponents() {//GEN-BEGIN:initComponents

        jMenuItem1 = new javax.swing.JMenuItem();
        imgeBank = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();
        jMenuBarPrincipal = new javax.swing.JMenuBar();
        jMenuFile = new javax.swing.JMenu();
        jMenuExit = new javax.swing.JMenuItem();
        jMenuClients = new javax.swing.JMenu();
        jMenuItemListClients = new javax.swing.JMenuItem();
        jMenuItemFindClient = new javax.swing.JMenuItem();
        jMenuItemAddClient = new javax.swing.JMenuItem();
        jMenuItemUpdateClient = new javax.swing.JMenuItem();
        jMenuItemDeleteClient = new javax.swing.JMenuItem();
        jMenuRegProduct = new javax.swing.JMenu();
        jMenuListAllRecords = new javax.swing.JMenuItem();
        jMenuItemListAll = new javax.swing.JMenuItem();
        jMenuItemRegProcut = new javax.swing.JMenuItem();
        jMenuItemFindProductRegistration = new javax.swing.JMenuItem();
        jMenuItemUpdateReg = new javax.swing.JMenuItem();
        jMenuItemDeleteProductRegistration = new javax.swing.JMenuItem();
        jMenuHelp = new javax.swing.JMenu();
        jMenuItemAbout = new javax.swing.JMenuItem();

        jMenuItem1.setText("jMenuItem1");

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Bank - Principal");
        setResizable(false);

        jLabel1.setFont(new java.awt.Font("Lucida Calligraphy", 0, 24)); // NOI18N
        jLabel1.setText("The Bank");

        jMenuFile.setText("Archivo");

        jMenuExit.setText("Salir");
        jMenuExit.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuExitActionPerformed(evt);
            }
        });
        jMenuFile.add(jMenuExit);

        jMenuBarPrincipal.add(jMenuFile);

        jMenuClients.setText("Clientes");

        jMenuItemListClients.setText("Listar clientes");
        jMenuItemListClients.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemListClientsActionPerformed(evt);
            }
        });
        jMenuClients.add(jMenuItemListClients);

        jMenuItemFindClient.setText("Buscar cliente");
        jMenuItemFindClient.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemFindClientActionPerformed(evt);
            }
        });
        jMenuClients.add(jMenuItemFindClient);

        jMenuItemAddClient.setText("Agregar cliente");
        jMenuItemAddClient.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemAddClientActionPerformed(evt);
            }
        });
        jMenuClients.add(jMenuItemAddClient);

        jMenuItemUpdateClient.setText("Actualizar cliente");
        jMenuItemUpdateClient.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemUpdateClientActionPerformed(evt);
            }
        });
        jMenuClients.add(jMenuItemUpdateClient);

        jMenuItemDeleteClient.setText("Eliminar cliente");
        jMenuItemDeleteClient.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemDeleteClientActionPerformed(evt);
            }
        });
        jMenuClients.add(jMenuItemDeleteClient);

        jMenuBarPrincipal.add(jMenuClients);

        jMenuRegProduct.setText("Registros");

        jMenuListAllRecords.setText("Listar todos los registros");
        jMenuListAllRecords.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuListAllRecordsActionPerformed(evt);
            }
        });
        jMenuRegProduct.add(jMenuListAllRecords);

        jMenuItemListAll.setText("Listar registros por cliente");
        jMenuItemListAll.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemListAllActionPerformed(evt);
            }
        });
        jMenuRegProduct.add(jMenuItemListAll);

        jMenuItemRegProcut.setText("Registrar producto a un cliente");
        jMenuItemRegProcut.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemRegProcutActionPerformed(evt);
            }
        });
        jMenuRegProduct.add(jMenuItemRegProcut);

        jMenuItemFindProductRegistration.setText("Buscar registro");
        jMenuItemFindProductRegistration.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemFindProductRegistrationActionPerformed(evt);
            }
        });
        jMenuRegProduct.add(jMenuItemFindProductRegistration);

        jMenuItemUpdateReg.setText("Actualizar registro");
        jMenuItemUpdateReg.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemUpdateRegActionPerformed(evt);
            }
        });
        jMenuRegProduct.add(jMenuItemUpdateReg);

        jMenuItemDeleteProductRegistration.setText("Eliminar Registro");
        jMenuItemDeleteProductRegistration.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemDeleteProductRegistrationActionPerformed(evt);
            }
        });
        jMenuRegProduct.add(jMenuItemDeleteProductRegistration);

        jMenuBarPrincipal.add(jMenuRegProduct);

        jMenuHelp.setText("Ayuda");

        jMenuItemAbout.setText("Acerca de");
        jMenuItemAbout.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jMenuItemAboutActionPerformed(evt);
            }
        });
        jMenuHelp.add(jMenuItemAbout);

        jMenuBarPrincipal.add(jMenuHelp);

        setJMenuBar(jMenuBarPrincipal);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(imgeBank, javax.swing.GroupLayout.PREFERRED_SIZE, 500, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(188, 188, 188)
                        .addComponent(jLabel1)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 11, Short.MAX_VALUE)
                .addComponent(imgeBank, javax.swing.GroupLayout.PREFERRED_SIZE, 456, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        pack();
    }//GEN-END:initComponents

    private void jMenuExitActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuExitActionPerformed
        System.exit(0);
    }//GEN-LAST:event_jMenuExitActionPerformed

    private void jMenuItemListClientsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemListClientsActionPerformed
        GUIListClients gui = new GUIListClients(this.clientController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemListClientsActionPerformed

    private void jMenuItemFindClientActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemFindClientActionPerformed
        GUIFindClient gui = new GUIFindClient(this.clientController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemFindClientActionPerformed

    private void jMenuItemAddClientActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemAddClientActionPerformed
        GUIAddClient gui = new GUIAddClient(this.clientController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemAddClientActionPerformed

    private void jMenuItemUpdateClientActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemUpdateClientActionPerformed
        GUIUpdateClient gui = new GUIUpdateClient(this.clientController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemUpdateClientActionPerformed

    private void jMenuItemDeleteClientActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemDeleteClientActionPerformed
        GUIDeleteClient gui = new GUIDeleteClient(this.clientController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemDeleteClientActionPerformed

    private void jMenuItemAboutActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemAboutActionPerformed
        JOptionPane.showMessageDialog(this, "Desarrollado por Ezequiel Melo & Andr�s Novoa  v. 1.2");
    }//GEN-LAST:event_jMenuItemAboutActionPerformed

    private void jMenuItemListAllActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemListAllActionPerformed
        GUIListProductRegistrationsByClient gui = new GUIListProductRegistrationsByClient(this.clientController, this.productController, this.productRegistrationController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemListAllActionPerformed

    private void jMenuItemFindProductRegistrationActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemFindProductRegistrationActionPerformed
        GUIFindProductRegistration gui = new GUIFindProductRegistration(this.clientController, this.productController, this.productRegistrationController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemFindProductRegistrationActionPerformed

    private void jMenuItemRegProcutActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemRegProcutActionPerformed
        GUIAddProductRegistration gui = new GUIAddProductRegistration(this.clientController, this.productController, this.productRegistrationController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemRegProcutActionPerformed

    private void jMenuItemUpdateRegActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemUpdateRegActionPerformed
        GUIUpdateProductRegistration gui = new GUIUpdateProductRegistration(this.clientController, this.productController, this.productRegistrationController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemUpdateRegActionPerformed

    private void jMenuListAllRecordsActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuListAllRecordsActionPerformed
        GUIListAllProductsRegistrations gui  = new GUIListAllProductsRegistrations(this.productController, this.productRegistrationController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuListAllRecordsActionPerformed

    private void jMenuItemDeleteProductRegistrationActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jMenuItemDeleteProductRegistrationActionPerformed
        GUIDeleteProductRegistration gui = new GUIDeleteProductRegistration(this.clientController, this.productController, this.productRegistrationController);
        gui.setLocationRelativeTo(null);
        gui.setVisible(true);
    }//GEN-LAST:event_jMenuItemDeleteProductRegistrationActionPerformed

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel imgeBank;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JMenuBar jMenuBarPrincipal;
    private javax.swing.JMenu jMenuClients;
    private javax.swing.JMenuItem jMenuExit;
    private javax.swing.JMenu jMenuFile;
    private javax.swing.JMenu jMenuHelp;
    private javax.swing.JMenuItem jMenuItem1;
    private javax.swing.JMenuItem jMenuItemAbout;
    private javax.swing.JMenuItem jMenuItemAddClient;
    private javax.swing.JMenuItem jMenuItemDeleteClient;
    private javax.swing.JMenuItem jMenuItemDeleteProductRegistration;
    private javax.swing.JMenuItem jMenuItemFindClient;
    private javax.swing.JMenuItem jMenuItemFindProductRegistration;
    private javax.swing.JMenuItem jMenuItemListAll;
    private javax.swing.JMenuItem jMenuItemListClients;
    private javax.swing.JMenuItem jMenuItemRegProcut;
    private javax.swing.JMenuItem jMenuItemUpdateClient;
    private javax.swing.JMenuItem jMenuItemUpdateReg;
    private javax.swing.JMenuItem jMenuListAllRecords;
    private javax.swing.JMenu jMenuRegProduct;
    // End of variables declaration//GEN-END:variables
}
