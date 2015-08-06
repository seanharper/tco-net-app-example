<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>2Checkout Sample App</title>
    <link rel="stylesheet" href="css/styles.css" type="text/css" />
</head>
<body>
    <div id="wrapper">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="scriptmanager1" runat="server"></asp:ScriptManager>
            <div id="customer_form" class="forms" runat="server">
                <h3>Create a Customer</h3>
                <hr />
                <asp:Label ID="lbl_first_name" runat="server" Text="First Name: " CssClass="label"></asp:Label><asp:TextBox ID="txt_first_name" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_last_name" runat="server" Text="Last Name: " CssClass="label"></asp:Label><asp:TextBox ID="txt_last_name" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_address" runat="server" Text="Address: " CssClass="label"></asp:Label><asp:TextBox ID="txt_address" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_city" runat="server" Text="City: " CssClass="label"></asp:Label><asp:TextBox ID="txt_city" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_state" runat="server" Text="State: " CssClass="label"></asp:Label><asp:TextBox ID="txt_state" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_zip" runat="server" Text="Zip: " CssClass="label"></asp:Label><asp:TextBox ID="txt_zip" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_country" runat="server" Text="Country: " CssClass="label"></asp:Label><asp:TextBox ID="txt_country" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_email" runat="server" Text="Email: " CssClass="label"></asp:Label><asp:TextBox ID="txt_email" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_phone" runat="server" Text="Phone: " CssClass="label"></asp:Label><asp:TextBox ID="txt_phone" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_currency" runat="server" Text="Currency: " CssClass="label"></asp:Label><asp:TextBox ID="txt_currency" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Button ID="btn_customer_submit" runat="server" OnClick="btn_customer_submit_Click" Text="Review" CssClass="input btn" />
            </div>

            <div id="pay_method_form" class="forms" runat="server">
                <h3>Add a Payment Method</h3>
                <hr />
                <asp:TextBox ID="txt_merchID" runat="server" CssClass="input hide" Text="123" ></asp:TextBox>
                <asp:Label ID="lbl_total" runat="server" Text="Order Total" CssClass="label"></asp:Label>
                <asp:Label ID="txt_total" runat="server"></asp:Label>
                <br />
                <br />
                <asp:Label ID="lbl_cc_number" runat="server" Text="Credit Card #: " CssClass="label"></asp:Label><asp:TextBox ID="txt_cc_number" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_exp_month" runat="server" Text="Exp Month: " CssClass="label"></asp:Label><asp:TextBox ID="txt_exp_month" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_exp_year" runat="server" Text="Exp Year: " CssClass="label"></asp:Label><asp:TextBox ID="txt_exp_year" runat="server" CssClass="input" ></asp:TextBox>
                <asp:Label ID="lbl_cvv" runat="server" Text="CVV Number: " CssClass="label"></asp:Label><asp:TextBox ID="txt_cvv" runat="server" CssClass="input"></asp:TextBox>
                <asp:Button ID="btn_complete_sale_submit" runat="server" OnClick="btn_complete_sale_submit_Click" Text="Complete Sale" CssClass="input btn" />
            </div>

            <div id="json_text" runat="server">
                <div id="payload" class="json">
                    <h3>Sent Payload</h3><asp:TextBox ID="json_payload" runat="server" Rows="35" Columns="55" TextMode="MultiLine" />
                </div>
                <div id="response" class="json">
                    <h3>Received Response</h3><asp:TextBox ID="json_response" runat="server" Rows="35" Columns="55" TextMode="MultiLine" />
                </div>
            </div>
        </form>
    </div>
</body>
</html>
