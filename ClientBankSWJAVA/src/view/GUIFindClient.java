/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package view;

import controller.ClientController;

import javax.swing.ImageIcon;
import javax.swing.JOptionPane;

import webservices.Client;

/**
 *
 * @author Sherg
 */
public class GUIFindClient extends javax.swing.JFrame implements IObserver {

    private ClientController clientController;
    private Observer observer;

    /**
     * Creates new form GUIFindClient
     */
    public GUIFindClient(ClientController controller) {
        initComponents();
        this.labIconFind.setIcon(new ImageIcon("images/iconFind.png"));

        this.clientController = controller;
        this.observer = Observer.getIstance();
        observer.addObserver(this);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabelIdNumber = new javax.swing.JLabel();
        jTextFieldIdNumber = new javax.swing.JTextField();
        jButtonFind = new javax.swing.JButton();
        jTextFieldName = new javax.swing.JTextField();
        jTextFieldEmail = new javax.swing.JTextField();
        jTextFieldPhoneNumber = new javax.swing.JTextField();
        jTextFieldGender = new javax.swing.JTextField();
        jLabName = new javax.swing.JLabel();
        jLabBithday = new javax.swing.JLabel();
        jLabEmail = new javax.swing.JLabel();
        jLabPhoneNumber = new javax.swing.JLabel();
        jLabBalance = new javax.swing.JLabel();
        jDateChooserBirthday = new com.toedter.calendar.JDateChooser();
        labIconFind = new javax.swing.JLabel();
        labTitle = new javax.swing.JLabel();
        txtDocType = new javax.swing.JTextField();
        labDocType = new javax.swing.JLabel();

        setDefaultCloseOperation(javax.swing.WindowConstants.DISPOSE_ON_CLOSE);
        setTitle("Buscar Cliente");
        setResizable(false);

        jLabelIdNumber.setText("Número de identificación:");

        jButtonFind.setFont(new java.awt.Font("Lucida Handwriting", 0, 12)); // NOI18N
        jButtonFind.setText("Buscar");
        jButtonFind.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButtonFindActionPerformed(evt);
            }
        });

        jLabName.setText("Nombre:");

        jLabBithday.setText("Fecha de naciemiento:");

        jLabEmail.setText("E-mail:");

        jLabPhoneNumber.setText("Telefono:");

        jLabBalance.setText("Género:");
        jLabBalance.setToolTipText("");

        labTitle.setFont(new java.awt.Font("Lucida Calligraphy", 0, 24)); // NOI18N
        labTitle.setText("Buscar cliente");

        labDocType.setText("Tipo de documento:");

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(18, 18, 18)
                .addComponent(labIconFind, javax.swing.GroupLayout.PREFERRED_SIZE, 178, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabName)
                    .addComponent(jLabBithday)
                    .addComponent(jLabEmail)
                    .addComponent(jLabPhoneNumber)
                    .addComponent(jLabBalance)
                    .addComponent(labDocType, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                    .addComponent(jTextFieldName, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jTextFieldGender, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jTextFieldPhoneNumber, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jTextFieldEmail, javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jDateChooserBirthday, javax.swing.GroupLayout.DEFAULT_SIZE, 224, Short.MAX_VALUE)
                    .addComponent(txtDocType))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(182, 182, 182)
                        .addComponent(labTitle))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(48, 48, 48)
                        .addComponent(jLabelIdNumber)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jTextFieldIdNumber, javax.swing.GroupLayout.PREFERRED_SIZE, 235, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addComponent(jButtonFind)))
                .addContainerGap(53, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(labTitle)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTextFieldIdNumber, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabelIdNumber)
                    .addComponent(jButtonFind))
                .addGap(17, 17, 17)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(labDocType)
                            .addComponent(txtDocType, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabName)
                            .addComponent(jTextFieldName, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                            .addComponent(jDateChooserBirthday, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                            .addComponent(jLabBithday, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jTextFieldEmail, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabEmail))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jTextFieldPhoneNumber, javax.swing.GroupLayout.PREFERRED_SIZE, 20, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabPhoneNumber))
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabBalance)
                            .addComponent(jTextFieldGender, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGap(0, 21, Short.MAX_VALUE))
                    .addComponent(labIconFind, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButtonFindActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButtonFindActionPerformed
        String strIdNumber = jTextFieldIdNumber.getText().trim();

        try {
            Client client = this.clientController.findClientById(strIdNumber);

            jTextFieldIdNumber.setText(String.valueOf(client.getIdentificationNumber()));
            txtDocType.setText(client.getDocumetType());
            jTextFieldName.setText(client.getName());

            long time = client.getBirthday().toGregorianCalendar().getTime().getTime();
            java.sql.Date date = new java.sql.Date(time);
            jDateChooserBirthday.setDate(date);

            jTextFieldEmail.setText(client.getEmail());
            jTextFieldPhoneNumber.setText(client.getPhoneNumber());
            jTextFieldGender.setText(client.getGender());

            txtDocType.setEditable(false);
            jTextFieldName.setEditable(false);
            jDateChooserBirthday.setEnabled(false);
            jTextFieldEmail.setEditable(false);
            jTextFieldPhoneNumber.setEditable(false);
            jTextFieldGender.setEditable(false);

        } catch (Exception e) {
            JOptionPane.showMessageDialog(this, e.getMessage(), "Error", JOptionPane.WARNING_MESSAGE);
        }
    }//GEN-LAST:event_jButtonFindActionPerformed

    @Override
    public void update() {

        Client client = observer.getClient();

        if (client != null) {
            jTextFieldIdNumber.setText(String.valueOf(client.getIdentificationNumber()));
            txtDocType.setText(client.getDocumetType());
            jTextFieldName.setText(client.getName());
            
            long time = client.getBirthday().toGregorianCalendar().getTime().getTime();
            java.sql.Date date = new java.sql.Date(time);
            jDateChooserBirthday.setDate(date);
            
            jTextFieldEmail.setText(client.getEmail());
            jTextFieldPhoneNumber.setText(client.getPhoneNumber());
            jTextFieldGender.setText(client.getGender());
        } else {
            jTextFieldIdNumber.setText("");
            txtDocType.setText("");
            jTextFieldName.setText("");
            jDateChooserBirthday.setDate(null);
            jTextFieldEmail.setText("");
            jTextFieldPhoneNumber.setText("");
            jTextFieldGender.setText("");
        }
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButtonFind;
    private com.toedter.calendar.JDateChooser jDateChooserBirthday;
    private javax.swing.JLabel jLabBalance;
    private javax.swing.JLabel jLabBithday;
    private javax.swing.JLabel jLabEmail;
    private javax.swing.JLabel jLabName;
    private javax.swing.JLabel jLabPhoneNumber;
    private javax.swing.JLabel jLabelIdNumber;
    private javax.swing.JTextField jTextFieldEmail;
    private javax.swing.JTextField jTextFieldGender;
    private javax.swing.JTextField jTextFieldIdNumber;
    private javax.swing.JTextField jTextFieldName;
    private javax.swing.JTextField jTextFieldPhoneNumber;
    private javax.swing.JLabel labDocType;
    private javax.swing.JLabel labIconFind;
    private javax.swing.JLabel labTitle;
    private javax.swing.JTextField txtDocType;
    // End of variables declaration//GEN-END:variables

}