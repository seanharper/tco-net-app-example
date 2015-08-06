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
    }

    private void populateCustomerForm()
    {
        txt_first_name.Text = "Test";
        txt_last_name.Text = "Tester";
        txt_email.Text = "test@email.com";
        txt_phone.Text = "555-555-5555";
        txt_address.Text = "123 Main St";
        txt_city.Text = "Columbus";
        txt_state.Text = "OH";
        txt_zip.Text = "43230";
        txt_country.Text = "USA";
        txt_currency.Text = "USD";

        String fullname = txt_first_name.Text + " " + txt_last_name.Text;
        String address = txt_address.Text;
        String email = txt_email.Text;
        String phone = txt_phone.Text;
        String city = txt_city.Text;
        String state = txt_state.Text;
        String zip = txt_zip.Text;
        String country = txt_country.Text;
        String currency = txt_currency.Text;

        address_data.Add("name", fullname);
        address_data.Add("address_1", address);
        address_data.Add("city", city);
        address_data.Add("state", state);
        address_data.Add("country_code", country);
        address_data.Add("postal_code", zip);

        customer_data.Add("email", email);
        customer_data.Add("phone", phone);
        customer_data.Add("currency", currency);
    }

    private void showCustomerForm()
    {
        hideForms();
        customer_form.Visible = true;
        populateCustomerForm();
    }

    protected void btn_customer_submit_Click(object sender, EventArgs e)
    {
        showPayMethodForm();
    }

    protected void hideForms()
    {
        customer_form.Visible = false;
        pay_method_form.Visible = false;
    }

    private void showPayMethodForm()
    {
        hideForms();
        pay_method_form.Visible = true;
        populatePayMethodForm();
    }

    private void populatePayMethodForm()
    {
        String cc_number = "4111111111111111";
        String exp_month = "12";
        String exp_year = "2019";
        String cvv = "123";
        String total = "25.00";

        txt_cc_number.Text = cc_number;
        txt_cvv.Text = cvv;
        txt_exp_month.Text = exp_month;
        txt_exp_year.Text = exp_year;
        txt_total.Text = "$" + total;

        credit_care_data.Add("number", cc_number);
        credit_care_data.Add("cvv", cvv);
        credit_care_data.Add("exp_month", int.Parse(exp_month));
        credit_care_data.Add("exp_year", int.Parse(exp_year));

        payment_method_data.Add("address", address_data);
        payment_method_data.Add("credit_card", credit_care_data);

        sale_data.Add("amount", total);
    }

    protected void btn_complete_sale_submit_Click(object sender, EventArgs e)
    {
        String merch_id = txt_merchID.Text;
        sale_data.Add("merchant_order_id", merch_id);
        sale_data.Add("customer", customer_data);

        Response.Write(sale_data);
    }
}