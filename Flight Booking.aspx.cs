using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HARRE_agency
{
    public partial class Flight_Booking : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (txtAdults.Text != string.Empty & txtChildren.Text != string.Empty && txtInfants.Text != string.Empty
                    && Convert.ToInt16(txtInfants.Text) > -1 && Convert.ToInt16(txtAdults.Text) > -1 && Convert.ToInt16(txtChildren.Text) > -1)
                    NumPassengers.Text = (Convert.ToInt32(txtAdults.Text) + Convert.ToInt32(txtChildren.Text) + Convert.ToInt32(txtInfants.Text)).ToString();

                else
                    lblWarning.Visible = true;
            }
            catch
            {
                lblWarning.Visible = true;
            }
        }

        protected void txtAdults_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtAdults.Text != string.Empty & txtChildren.Text != string.Empty && txtInfants.Text != string.Empty
                    && Convert.ToInt16(txtInfants.Text) > -1 && Convert.ToInt16(txtAdults.Text) > -1 && Convert.ToInt16(txtChildren.Text) > -1)
                    NumPassengers.Text = (Convert.ToInt32(txtAdults.Text) + Convert.ToInt32(txtChildren.Text) + Convert.ToInt32(txtInfants.Text)).ToString();
                 
                else
                    lblWarning.Visible = true;
            }
            catch
            {
                lblWarning.Visible = true;
            }
    }
        string nameclass = "";
        protected void txtChildren_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if(txtAdults.Text != string.Empty & txtChildren.Text != string.Empty && txtInfants.Text != string.Empty
                     && Convert.ToInt16(txtInfants.Text) > -1 && Convert.ToInt16(txtAdults.Text) > -1 && Convert.ToInt16(txtChildren.Text) > -1)
                     NumPassengers.Text = (Convert.ToInt32(txtAdults.Text) + Convert.ToInt32(txtChildren.Text) + Convert.ToInt32(txtInfants.Text)).ToString();
             else
                    lblWarning.Visible = true;
            }
            catch
            {
                lblWarning.Visible = true;
            }
        }

        protected void txtInfants_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtAdults.Text != string.Empty & txtChildren.Text != string.Empty && txtInfants.Text != string.Empty
                    &&Convert.ToInt16(txtInfants.Text)>-1 && Convert.ToInt16(txtAdults.Text) > -1 && Convert.ToInt16(txtChildren.Text) > -1)
                    NumPassengers.Text = (Convert.ToInt32(txtAdults.Text) + Convert.ToInt32(txtChildren.Text) + Convert.ToInt32(txtInfants.Text)).ToString();
                else
                    lblWarning.Visible = true;
            }
            catch
            {
                lblWarning.Visible = true;
            }
        }

        protected void ListTo_SelectedIndexChanged(object sender, EventArgs e)
        { string from= listFrom.SelectedValue;
            string To= ListTo.SelectedValue;
            if (from == To)
                ListTo.SelectedValue = null;
        }

        protected void listFrom_SelectedIndexChanged(object sender, EventArgs e)
        { 

        }
        string selectFrom = "";
        string SelectedItem = "";
        protected void CalendarFrom_SelectionChanged(object sender, EventArgs e)
        {
        }
        string selectTo = "";
        string months = "";
        int x = 0;
        int y = 0;
        int z = 0;

        protected void Button1_Click(object sender, EventArgs e)
        {//3
            {
                if (RadioButtonList.SelectedItem == null)
                { lblWarning2.Visible = true; return; }
                else
                    lblWarning2.Visible = false;
            }
            //1
            {
                if (listFrom.SelectedValue == null || ListTo.SelectedValue == null || listFrom.SelectedIndex == 0 || ListTo.SelectedIndex == 0)
                {
                    lblWarning0.Visible = true;
                    return;
                }
                else
                    lblWarning0.Visible = false;
            }



            //4
            {
                if (RadioButtonList.SelectedIndex == 1)
                {
                    if (ListMonth1.SelectedIndex == null || ListDay1 == null)
                        lblWarning3.Visible = true;
                    else { lblWarning3.Visible = false; }
                }
                else
                {
                    if (ListMonth1.SelectedIndex == null || ListDay1 == null||ListMonth2.SelectedIndex==null||ListDay2.SelectedIndex==null)
                        lblWarning3.Visible = true;
                    else { lblWarning3.Visible = false; }
                }
            }  //5
            //calender

            //2
            {
                if (NumPassengers.Text == "0")
                { lblWarning1.Visible = true; return; }
                else
                { lblWarning1.Visible = false; }
            
            }

            //Label13.Visible = true;
            //RadioButtonList1.Visible = true;
            RadioButtonList1.Items.Clear();
            if (listFrom.SelectedItem.Text.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            {
                RadioButtonList1.Items.Add("King Khaled International Airport");
            }
            else if (listFrom.SelectedItem.Text.Equals("Jeddah, Saudi ArabiaJeddah, Saudi Arabia"))
            {
                RadioButtonList1.Items.Add("King Abdiulaziz International Airport");
            }
            else if (listFrom.SelectedItem.Text.Equals("Dammam, Saudi ArabiaDammam, Saudi Arabia"))
            {
                RadioButtonList1.Items.Add("King Fahad International Airport");
            }
            else if (listFrom.SelectedItem.Text.Equals("New YorkNew York"))
            {
                RadioButtonList1.Items.Add("Newark Liberty International Airport");
            }
            else if (listFrom.SelectedItem.Text.Equals("London"))
            {
                RadioButtonList1.Items.Add("London Heathrow Airport");
            }
            else if (listFrom.SelectedItem.Text.Equals("Rome"))
            {
                RadioButtonList1.Items.Add("Rome–Ciampino International Airport ");
            }
            else if (listFrom.SelectedItem.Text.Equals("Sydney"))
            {
                RadioButtonList1.Items.Add("Sydney Airport");
                //  RadioButtonList1.Text.
            }
            else
            {
                RadioButtonList1.Items.Add("Tokyo Haneda Airport");
            }
            //===================================================
            // get month
           

                if (ListMonth1.Items.Count > 0)
                {
                    for (int i = 1; i < ListMonth1.Items.Count; i++)
                    {
                        if (ListMonth1.Items[i].Selected)
                        {
                            if (months == "")
                            {
                                months = ListMonth1.Items[i].Value;
                                break;
                            }
                        }
                    }


                } 
                // get class
                if (ListClass.Items.Count >= 0)
                {
                    for (int i = 0; i < ListClass.Items.Count; i++)
                    {
                        if (ListClass.Items[i].Selected)
                        {
                            if (nameclass == "")
                            {
                                nameclass = ListClass.Items[i].Value;
                                break;
                            }
                        }
                    }


                }
                // get day
                if (ListDay1.Items.Count > 0)
                {
                    for (int i = 1; i < ListDay1.Items.Count; i++)
                    {
                        if (ListDay1.Items[i].Selected)
                        {
                            if (SelectedItem == "")
                            {
                                SelectedItem = ListDay1.Items[i].Value;

                                break;
                            }
                        }
                    }
                }

                // to
                if (ListTo.Items.Count > 0)
                {
                    for (int i = 1; i < ListTo.Items.Count; i++)
                    {
                        if (ListTo.Items[i].Selected)
                        {
                            if (selectTo == "")
                            {
                                selectTo = listFrom.Items[i].Value;

                                break;
                            }
                        }
                    }
                }
                // from
                if (listFrom.Items.Count > 0)
                {
                    for (int i = 1; i < listFrom.Items.Count; i++)
                    {
                        if (listFrom.Items[i].Selected)
                        {
                            if (selectFrom == "")
                            {
                                selectFrom = listFrom.Items[i].Value;

                                break;
                            }
                        }
                    }
                }
                if (RadioButtonList.SelectedItem.Text.Equals("one-way"))
               {
                //if (months.Equals("February") || months.Equals("April") || months.Equals("June") || months.Equals("Augest"))
                //{
                    x = Convert.ToInt32(txtAdults.Text);
                    y = Convert.ToInt32(txtChildren.Text);
                    z = Convert.ToInt32(txtInfants.Text);

                // for (int i = 2; i < 20; i += 3)
                // {

                   if (nameclass.Equals("Premium Economy"))
                {
                    bool flage = true;
                    // month and data
                    if (months.Equals("February") || months.Equals("April") || months.Equals("June") || months.Equals("Augest"))
                    {
                       
                        if (! (SelectedItem.Equals("1")))
                        {
                            
                            for (int i = 1; i < 20; i +=6)
                            {
                                if (x <= 50 && y < 20 && z <= 10)
                                {
                                    flage = false;
                                    if (i < 12)
                                    {
                                        ListBox1.Items.Add(SelectedItem + months + "  " + selectFrom + " ------> " + selectTo + nameclass + i.ToString() + " a.m");
                                    }

                                    else
                                    {
                                        ListBox1.Items.Add(SelectedItem + months + "  " + selectFrom + " ------> " + selectTo + nameclass + i.ToString() + " p.m");
                                        //ListBox1.Items.Add(i.ToString() + " p.m");
                                    }
                                }
                                else
                                {
                                  for (int j = 4; j < 24; j += 3)
                                        if (x <= 80 && y < 20 && z <= 10)
                                          
                                        {
                                            if (j < 12)
                                                ListBox1.Items.Add("Time: " + j.ToString() + " a.m");
                                            else
                                                ListBox1.Items.Add("Time: " + j.ToString() + " p.m");
                                        }
                                        else
                                        {
                                            ListBox1.Items.Clear();
                                            LabelMessage.Visible = true;
                                            ListBox1.Items.Clear();
                                        }
                                }
                            }
                            //================== another 

                            //for (int i = 4; i < 24; i +=3)
                            //    if (x <= 50 && y < 20 && z <= 10)
                            //    {
                            //        if (i < 12)
                            //            ListBox1.Items.Add("Time: "+i.ToString() + " a.m");
                            //        else
                            //            ListBox1.Items.Add("Time: " + i.ToString() + " p.m");
                            //    }
                            //    else
                            //    {
                            //        ListBox1.Items.Clear();
                            //        LabelMessage.Visible = true;
                            //        ListBox1.Items.Clear();
                            //    }
                        }
                        else
                        // يداية الشهر 
                        {
                            LabelMessage.Visible = true;
                            LabelMessage.Text = "dmfndfdddddddddddddddddbg";
                        }
                    }
                    else if (months.Equals("January") || months.Equals("March") || months.Equals("May") || months.Equals("July"))
                    {

                    }

                    else
                    {

                    }
                }
                   else if(nameclass.Equals("First"))

                {

                }

                else if (nameclass.Equals("Business"))
                {

                }
                //else if (ListClass.SelectedItem.Equals("Business"))
                //{
                //    if (x <= 40 && y < 10 && z <= 3)
                //    {
                //        if (i < 12)
                //            ListBox1.Items.Add(i.ToString() + " a.m");
                //        else
                //            ListBox1.Items.Add(i.ToString() + " p.m");
                //    }
                //    else
                //    {
                //        ListBox1.Items.Clear();
                //        LabelMessage.Visible = true;
                //        ListBox1.Items.Clear();
                //    }

                //}
                //else if (ListClass.SelectedItem.Equals("First"))
                //{
                //    if (x <= 30 && y < 20 && z == 0)
                //    {
                //        if (i < 12)
                //            ListBox1.Items.Add(i.ToString() + " a.m");
                //        else
                //            ListBox1.Items.Add(i.ToString() + " p.m");
                //    }
                //    else
                //    {
                //        ListBox1.Items.Clear();
                //        LabelMessage.Visible = true;
                //        ListBox1.Items.Clear();
                //    }
                //}
                //else
                //{
                //    if (x <= 60 && y < 20 && z <= 10)
                //    {
                //        if (i < 12)
                //            ListBox1.Items.Add(i.ToString() + " a.m");
                //        else
                //            ListBox1.Items.Add(i.ToString() + " p.m");

                //        ListBox1.Items.Add(SelectedItem + months + "            " + selectFrom + " ------> " + selectTo + nameclass);
                //    }
                //    else
                //    {
                //        ListBox1.Items.Clear();
                //        LabelMessage.Visible = true;
                //        ListBox1.Items.Clear();
                //    }
                //}






                // }





                //===========





            }
                //============
               // ListBox1.Items.Clear();
            //    ListBox1.Items.Add(+SelectedItem + months + "  " + selectFrom + " ------> " + selectTo + nameclass);

              
                if (listFrom.SelectedItem.Text.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
                {
                    ListBox1.Items.Add("King Khaled International Airport");
                   

                }
                else if (listFrom.SelectedItem.Text.Equals("Jeddah, Saudi ArabiaJeddah, Saudi Arabia"))
                {
                    ListBox1.Items.Add("King Abdiulaziz International Airport");
                }
                else if (listFrom.SelectedItem.Text.Equals("Dammam, Saudi ArabiaDammam, Saudi Arabia"))
                {
                    ListBox1.Items.Add("King Fahad International Airport");
                }
                else if (listFrom.SelectedItem.Text.Equals("New YorkNew York"))
                {
                    ListBox1.Items.Add("Newark Liberty International Airport");
                }
                else if (listFrom.SelectedItem.Text.Equals("London"))
                {
                    ListBox1.Items.Add("London Heathrow Airport");
                }
                else if (listFrom.SelectedItem.Text.Equals("Rome"))
                {
                    ListBox1.Items.Add("Rome–Ciampino International Airport ");
                }
                else if (listFrom.SelectedItem.Text.Equals("Sydney"))
                {
                    ListBox1.Items.Add("Sydney Airport");
                   ListBox1.Items.Add(nameclass);
                    //  RadioButtonList1.Text.
                }
                else
                {

                }
            //    if (months.Equals("February") || months.Equals("April") || months.Equals("June") || months.Equals("Augest"))
            //    {
            //        x = Convert.ToInt32(txtAdults.Text);
            //        y = Convert.ToInt32(txtChildren.Text);
            //        z = Convert.ToInt32(txtInfants.Text);
            //        for (int i = 2; i < 20; i += 3)
            //        {
            //            if (nameclass.Equals("Economy"))
            //            {
            //                // السعة 
            //                if (x <= 60 && y < 20 && z <= 10)
            //                {
            //                    if (i < 12)
            //                        ListBox1.Items.Add(i.ToString() + " a.m");
            //                    else
            //                        ListBox1.Items.Add(i.ToString() + " p.m");
            //                }
            //                else
            //                {
            //                    ListBox1.Items.Clear();
            //                    LabelMessage.Visible = true;
            //                }

            //            }
            //            else if (ListClass.SelectedItem.Equals("Premium Economy"))
            //            {

            //            }
            //            else if (ListClass.SelectedItem.Equals("Business"))
            //            {

            //            }
            //            else if (ListClass.SelectedItem.Equals("First"))
            //            {

            //            }
            //            else
            //            {

            //            }
                       





            //        }

            //    }
               


            //    //===========

            
            //else
            //{
               
            //}
        }
        // end button 
        protected void ListDay1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListMonth1.SelectedIndex == 1)
            {
                ListDay1.Items.Clear();
                ListDay1.Items.Add("1");
                ListDay1.Items.Add("2");
                ListDay1.Items.Add("3");
                ListDay1.Items.Add("4");
                ListDay1.Items.Add("5");
                ListDay1.Items.Add("6");
                ListDay1.Items.Add("7");
                ListDay1.Items.Add("8");
                ListDay1.Items.Add("9");
                ListDay1.Items.Add("10");
                ListDay1.Items.Add("11");
                ListDay1.Items.Add("12");
                ListDay1.Items.Add("13");
                ListDay1.Items.Add("14");
                ListDay1.Items.Add("15");
                ListDay1.Items.Add("16");
                ListDay1.Items.Add("17");
                ListDay1.Items.Add("18");
                ListDay1.Items.Add("19");
                ListDay1.Items.Add("20");
                ListDay1.Items.Add("21");
                ListDay1.Items.Add("22");
                ListDay1.Items.Add("23");
                ListDay1.Items.Add("24");
                ListDay1.Items.Add("25");
                ListDay1.Items.Add("26");
                ListDay1.Items.Add("27");
            }
            if (ListMonth1.SelectedIndex == 3||ListMonth1.SelectedIndex==5||ListMonth1.SelectedIndex==8||ListMonth1.SelectedIndex==10)
            {
                ListDay1.Items.Clear();
                ListDay1.Items.Add("1");
                ListDay1.Items.Add("2");
                ListDay1.Items.Add("3");
                ListDay1.Items.Add("4");
                ListDay1.Items.Add("5");
                ListDay1.Items.Add("6");
                ListDay1.Items.Add("7");
                ListDay1.Items.Add("8");
                ListDay1.Items.Add("9");
                ListDay1.Items.Add("10");
                ListDay1.Items.Add("11");
                ListDay1.Items.Add("12");
                ListDay1.Items.Add("13");
                ListDay1.Items.Add("14");
                ListDay1.Items.Add("15");
                ListDay1.Items.Add("16");
                ListDay1.Items.Add("17");
                ListDay1.Items.Add("18");
                ListDay1.Items.Add("19");
                ListDay1.Items.Add("20");
                ListDay1.Items.Add("21");
                ListDay1.Items.Add("22");
                ListDay1.Items.Add("23");
                ListDay1.Items.Add("24");
                ListDay1.Items.Add("25");
                ListDay1.Items.Add("26");
                ListDay1.Items.Add("27");
                ListDay1.Items.Add("28");
                ListDay1.Items.Add("29");
                ListDay1.Items.Add("30");
            }
        }

        protected void ListDay2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (ListMonth1.SelectedIndex == 1)
            {
                ListDay1.Items.Clear();
                ListDay1.Items.Add("1");
                ListDay1.Items.Add("2");
                ListDay1.Items.Add("3");
                ListDay1.Items.Add("4");
                ListDay1.Items.Add("5");
                ListDay1.Items.Add("6");
                ListDay1.Items.Add("7");
                ListDay1.Items.Add("8");
                ListDay1.Items.Add("9");
                ListDay1.Items.Add("10");
                ListDay1.Items.Add("11");
                ListDay1.Items.Add("12");
                ListDay1.Items.Add("13");
                ListDay1.Items.Add("14");
                ListDay1.Items.Add("15");
                ListDay1.Items.Add("16");
                ListDay1.Items.Add("17");
                ListDay1.Items.Add("18");
                ListDay1.Items.Add("19");
                ListDay1.Items.Add("20");
                ListDay1.Items.Add("21");
                ListDay1.Items.Add("22");
                ListDay1.Items.Add("23");
                ListDay1.Items.Add("24");
                ListDay1.Items.Add("25");
                ListDay1.Items.Add("26");
                ListDay1.Items.Add("27");
            }
            if (ListMonth1.SelectedIndex == 3||ListMonth1.SelectedIndex==5||ListMonth1.SelectedIndex==8||ListMonth1.SelectedIndex==10)
            {
                ListDay1.Items.Clear();
                ListDay1.Items.Add("1");
                ListDay1.Items.Add("2");
                ListDay1.Items.Add("3");
                ListDay1.Items.Add("4");
                ListDay1.Items.Add("5");
                ListDay1.Items.Add("6");
                ListDay1.Items.Add("7");
                ListDay1.Items.Add("8");
                ListDay1.Items.Add("9");
                ListDay1.Items.Add("10");
                ListDay1.Items.Add("11");
                ListDay1.Items.Add("12");
                ListDay1.Items.Add("13");
                ListDay1.Items.Add("14");
                ListDay1.Items.Add("15");
                ListDay1.Items.Add("16");
                ListDay1.Items.Add("17");
                ListDay1.Items.Add("18");
                ListDay1.Items.Add("19");
                ListDay1.Items.Add("20");
                ListDay1.Items.Add("21");
                ListDay1.Items.Add("22");
                ListDay1.Items.Add("23");
                ListDay1.Items.Add("24");
                ListDay1.Items.Add("25");
                ListDay1.Items.Add("26");
                ListDay1.Items.Add("27");
                ListDay1.Items.Add("28");
                ListDay1.Items.Add("29");
                ListDay1.Items.Add("30");
            }

        }

        protected void RadioButtonList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        { }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if(RadioButtonList1.Text.Equals("sa"))
            //if (listFrom.Items.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{

            //}
            //else if(listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}
            //else if (listFrom.SelectedItem.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    ListBox1.Items.Add("dfghj");
            //}


            //if (listFrom.SelectedItem.Text.Equals("Riyadh, Saudi ArabiaRiyadh, Saudi Arabia"))
            //{
            //    RadioButtonList1.Items.Add("King Khaled International Airport");
            //}
            // else if (listFrom.SelectedItem.Text.Equals("Jeddah, Saudi ArabiaJeddah, Saudi Arabia"))
            //{
            //    RadioButtonList1.Items.Add("King Abdiulaziz International Airport");
            //}
            //else if (listFrom.SelectedItem.Text.Equals("Dammam, Saudi ArabiaDammam, Saudi Arabia"))
            //{
            //    RadioButtonList1.Items.Add("King Fahad International Airport");
            //}
            //else if (listFrom.SelectedItem.Text.Equals("New YorkNew York"))
            //{
            //    RadioButtonList1.Items.Add("Newark Liberty International Airport");
            //}
            //else if (listFrom.SelectedItem.Text.Equals("London"))
            //{
            //    RadioButtonList1.Items.Add("London Heathrow Airport");
            //}
            //else if (listFrom.SelectedItem.Text.Equals("Rome"))
            //{
            //    RadioButtonList1.Items.Add("Rome–Ciampino International Airport ");
            //}
            //else if (listFrom.SelectedItem.Text.Equals("Sydney"))
            //{
            //    RadioButtonList1.Items.Add("Sydney Airport");
            //  //  RadioButtonList1.Text.
            //}
            //else 
            //{
            //    RadioButtonList1.Items.Add("Tokyo Haneda Airport");
            //}
          
           
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {
            
        }
    }
}