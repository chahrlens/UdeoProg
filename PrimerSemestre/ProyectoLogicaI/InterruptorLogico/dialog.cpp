#include "dialog.h"
#include "ui_dialog.h"

Dialog::Dialog(QWidget *parent)
    : QDialog(parent)
    , ui(new Ui::Dialog)
{
    ui->setupUi(this);
    ui->lineEdit->setReadOnly(true);
    ui->lcdNumber->setDigitCount(1);
    ui->lineEdit->setText("Alarma apagada");

    connect(ui->checkMotor, &QCheckBox::stateChanged, this, [&](int state){MOTOR = (bool) state;}, Qt::AutoConnection);

    connect(ui->checkDoor,  &QCheckBox::stateChanged, this, [&](int){actionsChecks();}, Qt::AutoConnection);
    connect(ui->checkLigth, &QCheckBox::stateChanged, this, [&](int){actionsChecks();}, Qt::AutoConnection);
    connect(ui->checkMotor, &QCheckBox::stateChanged, this, [&](int){actionsChecks();}, Qt::AutoConnection);
}

Dialog::~Dialog()
{
    delete ui;
}


void Dialog::setAlarmStatus(int state){
    ui->lcdNumber->display(state);
    ui->lineEdit->setText(msWarning);
}

void Dialog::actionsChecks(){
    bool door, ligth;
    door  = ui->checkDoor ->isChecked();
    ligth = ui->checkLigth->isChecked();

    msWarning = (MOTOR && door) ? "La Puerta esta abierta" : (!MOTOR && ligth) ? "El motor esta apagado con la luz encendida!" : "Alarma apagada";
    setAlarmStatus((MOTOR && door) || (!MOTOR && ligth));

}
