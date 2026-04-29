using System;
using Microsoft.Maui.Controls;

namespace PRG1_MAUI_ERP_Activum.View;

public partial class CalculatorPage : ContentPage
{
    private double _v1;
    private string _op = string.Empty;
    private bool _next = true;

    public CalculatorPage()
        {
        InitializeComponent();
        }

    private void OnNumberClicked(object sender, EventArgs e)
    {
        var b = (Button)sender;
        if (_next || DisplayLabel.Text == "0" || DisplayLabel.Text == "Error")
        {
            DisplayLabel.Text = b.Text;
            _next = false;
        }
        else
        {
            DisplayLabel.Text += b.Text;
        }
    } 

    private void OnOperatorClicked(object sender, EventArgs e)
    {
        var b = (Button)sender;

        if(double.TryParse(DisplayLabel.Text, out double val))
        {
            _v1 = val;
            _op = b.Text;
            _next = true;
        }
    }

    private void OnCalculateClicked(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(_op) || !double.TryParse(DisplayLabel.Text, out double v2))
            return;

        double r = 0;

        if (_op == "+") r = _v1 + v2;
        else if (_op == "-") r = _v1 - v2;
        else if (_op == "x") r = _v1 * v2;
        else if (_op == "/")
        {
            if (v2 == 0)
            {
                DisplayLabel.Text = "Error";
                _next = true;
                return;
            }
            r = _v1 / v2;
        }

        DisplayLabel.Text = r.ToString();
        _v1 = r;
        _op = string.Empty;
        _next = true;
    }

    private void OnClearClicked(object sender, EventArgs e)
    {
        DisplayLabel.Text = "0";
        _v1 = 0;
        _op = string.Empty;
        _next = true;
    }
}


