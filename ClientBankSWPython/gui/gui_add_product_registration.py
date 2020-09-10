# -*- coding: utf-8 -*-

# Form implementation generated from reading ui file 'GUIAddProductRegistration.ui'
#
# Created by: PyQt5 UI code generator 5.13.0
#
# WARNING! All changes made in this file will be lost!

import sys
from PyQt5 import QtCore, QtGui, QtWidgets


class Ui_GUI_Add_Product_Registration(object):
    def setupUi(self, GUI_Add_Product_Registration):
        GUI_Add_Product_Registration.setObjectName("GUI_Add_Product_Registration")
        GUI_Add_Product_Registration.resize(575, 360)
        sizePolicy = QtWidgets.QSizePolicy(QtWidgets.QSizePolicy.Fixed, QtWidgets.QSizePolicy.Fixed)
        sizePolicy.setHorizontalStretch(0)
        sizePolicy.setVerticalStretch(0)
        sizePolicy.setHeightForWidth(GUI_Add_Product_Registration.sizePolicy().hasHeightForWidth())
        GUI_Add_Product_Registration.setSizePolicy(sizePolicy)
        self.centralwidget = QtWidgets.QWidget(GUI_Add_Product_Registration)
        self.centralwidget.setObjectName("centralwidget")
        self.label_title = QtWidgets.QLabel(self.centralwidget)
        self.label_title.setGeometry(QtCore.QRect(0, 10, 575, 51))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(24)
        self.label_title.setFont(font)
        self.label_title.setContextMenuPolicy(QtCore.Qt.NoContextMenu)
        self.label_title.setLayoutDirection(QtCore.Qt.LeftToRight)
        self.label_title.setAlignment(QtCore.Qt.AlignCenter)
        self.label_title.setObjectName("label_title")
        self.verticalLayoutWidget = QtWidgets.QWidget(self.centralwidget)
        self.verticalLayoutWidget.setGeometry(QtCore.QRect(40, 80, 160, 201))
        self.verticalLayoutWidget.setObjectName("verticalLayoutWidget")
        self.verticalLayout = QtWidgets.QVBoxLayout(self.verticalLayoutWidget)
        self.verticalLayout.setContentsMargins(0, 0, 0, 0)
        self.verticalLayout.setObjectName("verticalLayout")
        self.label_client_id = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_client_id.setFont(font)
        self.label_client_id.setObjectName("label_client_id")
        self.verticalLayout.addWidget(self.label_client_id)
        self.label_product_code = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_product_code.setFont(font)
        self.label_product_code.setObjectName("label_product_code")
        self.verticalLayout.addWidget(self.label_product_code)
        self.label_product_number = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_product_number.setFont(font)
        self.label_product_number.setObjectName("label_product_number")
        self.verticalLayout.addWidget(self.label_product_number)
        self.label_balance = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_balance.setFont(font)
        self.label_balance.setObjectName("label_balance")
        self.verticalLayout.addWidget(self.label_balance)
        self.label_registration_date = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_registration_date.setFont(font)
        self.label_registration_date.setObjectName("label_registration_date")
        self.verticalLayout.addWidget(self.label_registration_date)
        self.label_expiration_date = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_expiration_date.setFont(font)
        self.label_expiration_date.setObjectName("label_expiration_date")
        self.verticalLayout.addWidget(self.label_expiration_date)
        self.label_state = QtWidgets.QLabel(self.verticalLayoutWidget)
        font = QtGui.QFont()
        font.setPointSize(11)
        self.label_state.setFont(font)
        self.label_state.setObjectName("label_state")
        self.verticalLayout.addWidget(self.label_state)
        self.txt_client_id = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_client_id.setGeometry(QtCore.QRect(210, 80, 271, 24))
        self.txt_client_id.setObjectName("txt_client_id")
        self.txt_product_number = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_product_number.setGeometry(QtCore.QRect(210, 140, 321, 24))
        self.txt_product_number.setObjectName("txt_product_number")
        self.txt_balance = QtWidgets.QTextEdit(self.centralwidget)
        self.txt_balance.setGeometry(QtCore.QRect(210, 170, 321, 24))
        self.txt_balance.setObjectName("txt_balance")
        self.btn_find_client = QtWidgets.QPushButton(self.centralwidget)
        self.btn_find_client.setGeometry(QtCore.QRect(490, 80, 41, 24))
        self.btn_find_client.setObjectName("btn_find_client")
        self.comboBox_product_code = QtWidgets.QComboBox(self.centralwidget)
        self.comboBox_product_code.setGeometry(QtCore.QRect(210, 110, 321, 24))
        self.comboBox_product_code.setObjectName("comboBox_product_code")
        self.dateEdit_registrtion_date = QtWidgets.QDateEdit(self.centralwidget)
        self.dateEdit_registrtion_date.setGeometry(QtCore.QRect(210, 200, 321, 24))
        self.dateEdit_registrtion_date.setObjectName("dateEdit_registrtion_date")
        self.dateEdit_expiration_date = QtWidgets.QDateEdit(self.centralwidget)
        self.dateEdit_expiration_date.setGeometry(QtCore.QRect(210, 230, 321, 24))
        self.dateEdit_expiration_date.setObjectName("dateEdit_expiration_date")
        self.radbtn_active = QtWidgets.QRadioButton(self.centralwidget)
        self.radbtn_active.setGeometry(QtCore.QRect(210, 260, 61, 24))
        self.radbtn_active.setObjectName("radbtn_active")
        self.radbtn_inactive = QtWidgets.QRadioButton(self.centralwidget)
        self.radbtn_inactive.setGeometry(QtCore.QRect(280, 260, 71, 24))
        self.radbtn_inactive.setObjectName("radbtn_inactive")
        self.btn_add_product_registration = QtWidgets.QPushButton(self.centralwidget)
        self.btn_add_product_registration.setGeometry(QtCore.QRect(190, 290, 201, 41))
        font = QtGui.QFont()
        font.setFamily("Lucida Handwriting")
        font.setPointSize(14)
        self.btn_add_product_registration.setFont(font)
        self.btn_add_product_registration.setObjectName("btn_add_product_registration")
        GUI_Add_Product_Registration.setCentralWidget(self.centralwidget)
        self.statusbar = QtWidgets.QStatusBar(GUI_Add_Product_Registration)
        self.statusbar.setObjectName("statusbar")
        GUI_Add_Product_Registration.setStatusBar(self.statusbar)

        self.retranslateUi(GUI_Add_Product_Registration)
        QtCore.QMetaObject.connectSlotsByName(GUI_Add_Product_Registration)

    def retranslateUi(self, GUI_Add_Product_Registration):
        _translate = QtCore.QCoreApplication.translate
        GUI_Add_Product_Registration.setWindowTitle(_translate("GUI_Add_Product_Registration", "Registrar producto a un cliente"))
        self.label_title.setText(_translate("GUI_Add_Product_Registration", "Registrar producto"))
        self.label_client_id.setText(_translate("GUI_Add_Product_Registration", "Documento del cliente:"))
        self.label_product_code.setText(_translate("GUI_Add_Product_Registration", "Producto:"))
        self.label_product_number.setText(_translate("GUI_Add_Product_Registration", "Número de producto:"))
        self.label_balance.setText(_translate("GUI_Add_Product_Registration", "Saldo:"))
        self.label_registration_date.setText(_translate("GUI_Add_Product_Registration", "Fecha de expedición:"))
        self.label_expiration_date.setText(_translate("GUI_Add_Product_Registration", "Fecha de vencimiento:"))
        self.label_state.setText(_translate("GUI_Add_Product_Registration", "Estado:"))
        self.btn_find_client.setText(_translate("GUI_Add_Product_Registration", "..."))
        self.radbtn_active.setText(_translate("GUI_Add_Product_Registration", "Activo"))
        self.radbtn_inactive.setText(_translate("GUI_Add_Product_Registration", "Inactivo"))
        self.btn_add_product_registration.setText(_translate("GUI_Add_Product_Registration", "Agregar registro"))