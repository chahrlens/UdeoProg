#ifndef DIALOG_H
#define DIALOG_H

#include <QDialog>
#include <QCheckBox>

QT_BEGIN_NAMESPACE
namespace Ui { class Dialog; }
QT_END_NAMESPACE

class Dialog : public QDialog
{
    Q_OBJECT

public:
    Dialog(QWidget *parent = nullptr);
    ~Dialog();

private:
    Ui::Dialog *ui;
    bool MOTOR = false;
    QString msWarning = "";
    void setAlarmStatus(int);
    void actionsChecks();

};
#endif // DIALOG_H
