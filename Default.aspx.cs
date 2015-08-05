using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    Dictionary<String, Object> customer_data= new Dictionary<String, Object>();
    Dictionary<String, Object> address_data = new Dictionary<String, Object>();
    Dictionary<String, Object> payment_method_data = new Dictionary<String, Object>();
    Dictionary<String, Object> credit_care_data = new Dictionary<String, Object>();
    Dictionary<String, Object> sale_data = new Dictionary<String, Object>();

    protected void Page_Load(object sender, EventArgs e)
    {
        hideForms();
        showCustomerForm();
        populateFormFields();
    }

    private void showCustomerForm()
    {
        hideForms();
        customer_form.Visible = true;
    }

    protected void populateFormFields()
    {
        txt_merchID.Text = "123";
        txt_amount.Text = "1.00";
    }
    protected void hideForms()
    {
        customer_form.Visible = false;
        pay_method_form.Visible = false;
        sale_form.Visible = false;
    }

    protected void btn_submit_Click(object sender, EventArgs e)
    {
        String merchId = txt_merchID.Text;
        Double amount = Convert.ToDouble(txt_amount.Text);
        //Response.Write("<script> alert('" + merchId + " : " + amount + "') ;</script>");

    }

    protected void btn_customer_submit_Click(object sender, EventArgs e)
    {
        //Collect Customer Data to Hash (Dictionary)
        showPayMethodForm();
    }

    private void showPayMethodForm()
    {
        hideForms();
        pay_method_form.Visible = true;
    }

    protected void btn_pay_method_submit_Click(object sender, EventArgs e)
    {
        //Collect Payment Method Data to Hash (Dictionary)
        showSaleForm();
    }

    private void showSaleForm()
    {
        hideForms();
        sale_form.Visible = true;
    }
}