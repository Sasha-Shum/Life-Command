using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.IO;

namespace MainScreen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Map : Window
    {
        SqlConnection cn = new SqlConnection(Singleton.connectionStringGlobal);
        SqlCommand cmd;             //Creates commands that will work with the database
        SqlDataReader dr;
        public Map()
        {
            InitializeComponent();
        }



 
        private void changeColor(object sender, MouseEventArgs e)
        {
        
                Russia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void changeColorBack(object sender, MouseEventArgs e)
        {
            Russia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void China_MouseEnter(object sender, MouseEventArgs e)
        {
          
                China.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void China_MouseLeave(object sender, MouseEventArgs e)
        {
            China.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Finland_MouseEnter(object sender, MouseEventArgs e)
        {
            Finland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Finland_MouseLeave(object sender, MouseEventArgs e)
        {
            Finland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Sweden_MouseEnter(object sender, MouseEventArgs e)
        {
            Sweden.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Sweden_MouseLeave(object sender, MouseEventArgs e)
        {
            Sweden.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Mongolia_MouseEnter(object sender, MouseEventArgs e)
        {
            Mongolia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Mongolia_MouseLeave(object sender, MouseEventArgs e)
        {
            Mongolia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Kazakhstan_MouseEnter(object sender, MouseEventArgs e)
        {
            Kazakhstan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Kazakhstan_MouseLeave(object sender, MouseEventArgs e)
        {
            Kazakhstan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Norway_MouseEnter(object sender, MouseEventArgs e)
        {
            Norway.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Norway_MouseLeave(object sender, MouseEventArgs e)
        {
            Norway.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Iceland_MouseEnter(object sender, MouseEventArgs e)
        {
            Iceland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Iceland_MouseLeave(object sender, MouseEventArgs e)
        {
           Iceland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Greenland_MouseEnter(object sender, MouseEventArgs e)
        {
           Greenland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Greenland_MouseLeave(object sender, MouseEventArgs e)
        {
            Greenland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);

        }

        private void Canada_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);

        }

        private void US_MouseEnter(object sender, MouseEventArgs e)
        {
            USA.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            USA1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            US.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void US_MouseLeave(object sender, MouseEventArgs e)
        {
            USA.Fill = new SolidColorBrush(Colors.LightGray);
            USA1.Fill = new SolidColorBrush(Colors.LightGray);
            US.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void USA_MouseEnter(object sender, MouseEventArgs e)
        {
            USA.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            USA1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            US.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void USA_MouseLeave(object sender, MouseEventArgs e)
        {
            USA.Fill = new SolidColorBrush(Colors.LightGray);
            USA1.Fill = new SolidColorBrush(Colors.LightGray);
            US.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Mexico_MouseEnter(object sender, MouseEventArgs e)
        {
            Mexico.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Mexico_MouseLeave(object sender, MouseEventArgs e)
        {
            Mexico.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Guatemala_MouseEnter(object sender, MouseEventArgs e)
        {
            Guatemala.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Guatemala_MouseLeave(object sender, MouseEventArgs e)
        {
            Guatemala.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Honduras_MouseEnter(object sender, MouseEventArgs e)
        {
            Honduras.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Honduras_MouseLeave(object sender, MouseEventArgs e)
        {
           Honduras.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Belize_MouseEnter(object sender, MouseEventArgs e)
        {
            Belize.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Belize_MouseLeave(object sender, MouseEventArgs e)
        {
            Belize.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void ElSalvador_MouseEnter(object sender, MouseEventArgs e)
        {
            ElSalvador.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void ElSalvador_MouseLeave(object sender, MouseEventArgs e)
        {
            ElSalvador.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Nicaragua_MouseEnter(object sender, MouseEventArgs e)
        {
            Nicaragua.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Nicaragua_MouseLeave(object sender, MouseEventArgs e)
        {
            Nicaragua.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void CostaRica_MouseEnter(object sender, MouseEventArgs e)
        {
            CostaRica.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void CostaRica_MouseLeave(object sender, MouseEventArgs e)
        {
            CostaRica.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Panama_MouseEnter(object sender, MouseEventArgs e)
        {
            Panama.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Panama_MouseLeave(object sender, MouseEventArgs e)
        {
            Panama.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Columbia_MouseEnter(object sender, MouseEventArgs e)
        {
            Columbia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Columbia_MouseLeave(object sender, MouseEventArgs e)
        {
            Columbia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Venezuela_MouseEnter(object sender, MouseEventArgs e)
        {
           Venezuela.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Venezuela_MouseLeave(object sender, MouseEventArgs e)
        {
            Venezuela.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Guyana_MouseEnter(object sender, MouseEventArgs e)
        {
            Guyana.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Guyana_MouseLeave(object sender, MouseEventArgs e)
        {
            Guyana.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Suriname_MouseEnter(object sender, MouseEventArgs e)
        {
            Suriname.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Suriname_MouseLeave(object sender, MouseEventArgs e)
        {
            Suriname.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void FrenchGuiana_MouseEnter(object sender, MouseEventArgs e)
        {
            FrenchGuiana.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void FrenchGuiana_MouseLeave(object sender, MouseEventArgs e)
        {
            FrenchGuiana.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Ecuador_MouseEnter(object sender, MouseEventArgs e)
        {
            Ecuador.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Ecuador_MouseLeave(object sender, MouseEventArgs e)
        {
            Ecuador.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Peru_MouseEnter(object sender, MouseEventArgs e)
        {
            Peru.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Peru_MouseLeave(object sender, MouseEventArgs e)
        {
            Peru.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Brazil_MouseEnter(object sender, MouseEventArgs e)
        {
            Brazil.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Brazil_MouseLeave(object sender, MouseEventArgs e)
        {
            Brazil.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Bolivia_MouseEnter(object sender, MouseEventArgs e)
        {
            Bolivia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Bolivia_MouseLeave(object sender, MouseEventArgs e)
        {
            Bolivia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Chile_MouseEnter(object sender, MouseEventArgs e)
        {
            Chile.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Chile_MouseLeave(object sender, MouseEventArgs e)
        {
            Chile.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Argentina_MouseEnter(object sender, MouseEventArgs e)
        {
            Argentina.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Argentina_MouseLeave(object sender, MouseEventArgs e)
        {
            Argentina.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Paraguay_MouseEnter(object sender, MouseEventArgs e)
        {
            Paraguay.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Paraguay_MouseLeave(object sender, MouseEventArgs e)
        {
            Paraguay.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Uruguay_MouseEnter(object sender, MouseEventArgs e)
        {
            Uruguay.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Uruguay_MouseLeave(object sender, MouseEventArgs e)
        {
            Uruguay.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void FalklandIslands_MouseEnter(object sender, MouseEventArgs e)
        {
            FalklandIslands.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void FalklandIslands_MouseLeave(object sender, MouseEventArgs e)
        {
            FalklandIslands.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void SouthAfrica_MouseEnter(object sender, MouseEventArgs e)
        {
            SouthAfrica.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void SouthAfrica_MouseLeave(object sender, MouseEventArgs e)
        {
            SouthAfrica.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Lesotho_MouseEnter(object sender, MouseEventArgs e)
        {
            Lesotho.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Lesotho_MouseLeave(object sender, MouseEventArgs e)
        {
            Lesotho.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Swaziland_MouseEnter(object sender, MouseEventArgs e)
        {
            Swaziland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Swaziland_MouseLeave(object sender, MouseEventArgs e)
        {
            Swaziland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Botswana_MouseEnter(object sender, MouseEventArgs e)
        {
            Botswana.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Botswana_MouseLeave(object sender, MouseEventArgs e)
        {
            Botswana.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Namibia_MouseEnter(object sender, MouseEventArgs e)
        {
            Namibia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Namibia_MouseLeave(object sender, MouseEventArgs e)
        {
            Namibia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Zimbabwe_MouseEnter(object sender, MouseEventArgs e)
        {
            Zimbabwe.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Zimbabwe_MouseLeave(object sender, MouseEventArgs e)
        {
            Zimbabwe.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Mozambique_MouseEnter(object sender, MouseEventArgs e)
        {
            Mozambique.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Mozambique_MouseLeave(object sender, MouseEventArgs e)
        {
            Mozambique.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Madagascar_MouseEnter(object sender, MouseEventArgs e)
        {
            Madagascar.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Madagascar_MouseLeave(object sender, MouseEventArgs e)
        {
            Madagascar.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Malawi_MouseEnter(object sender, MouseEventArgs e)
        {
            Malawi.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Malawi_MouseLeave(object sender, MouseEventArgs e)
        {
            Malawi.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Zambia_MouseEnter(object sender, MouseEventArgs e)
        {
            Zambia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Zambia_MouseLeave(object sender, MouseEventArgs e)
        {
            Zambia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Angola_MouseEnter(object sender, MouseEventArgs e)
        {
            Angola.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Angola_MouseLeave(object sender, MouseEventArgs e)
        {
            Angola.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Tanzania_MouseEnter(object sender, MouseEventArgs e)
        {
            Tanzania.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Tanzania_MouseLeave(object sender, MouseEventArgs e)
        {
            Tanzania.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void DRCongo_MouseEnter(object sender, MouseEventArgs e)
        {
            DRCongo.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void DRCongo_MouseLeave(object sender, MouseEventArgs e)
        {
            DRCongo.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Burundi_MouseEnter(object sender, MouseEventArgs e)
        {
            Burundi.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Burundi_MouseLeave(object sender, MouseEventArgs e)
        {
            Burundi.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Rwanda_MouseEnter(object sender, MouseEventArgs e)
        {
            Rwanda.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Rwanda_MouseLeave(object sender, MouseEventArgs e)
        {
            Rwanda.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Congo_MouseEnter(object sender, MouseEventArgs e)
        {
            Congo.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Congo_MouseLeave(object sender, MouseEventArgs e)
        {
            Congo.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Gabon_MouseEnter(object sender, MouseEventArgs e)
        {
            Gabon.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Gabon_MouseLeave(object sender, MouseEventArgs e)
        {
            Gabon.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void EquatorialGuinea_MouseEnter(object sender, MouseEventArgs e)
        {
            EquatorialGuinea.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void EquatorialGuinea_MouseLeave(object sender, MouseEventArgs e)
        {
            EquatorialGuinea.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Cameroun_MouseEnter(object sender, MouseEventArgs e)
        {
            Cameroun.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Cameroun_MouseLeave(object sender, MouseEventArgs e)
        {
            Cameroun.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void RepubliqueCentrafricaine_MouseEnter(object sender, MouseEventArgs e)
        {
            RepubliqueCentrafricaine.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void RepubliqueCentrafricaine_MouseLeave(object sender, MouseEventArgs e)
        {
            RepubliqueCentrafricaine.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void SouthSudan_MouseEnter(object sender, MouseEventArgs e)
        {
            SouthSudan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void SouthSudan_MouseLeave(object sender, MouseEventArgs e)
        {
            SouthSudan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Kenya_MouseEnter(object sender, MouseEventArgs e)
        {
            Kenya.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Kenya_MouseLeave(object sender, MouseEventArgs e)
        {
            Kenya.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Somalia_MouseEnter(object sender, MouseEventArgs e)
        {
            Somalia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Somalia_MouseLeave(object sender, MouseEventArgs e)
        {
            Somalia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Ethiopia_MouseEnter(object sender, MouseEventArgs e)
        {
            Ethiopia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Ethiopia_MouseLeave(object sender, MouseEventArgs e)
        {
            Ethiopia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Nigeria_MouseEnter(object sender, MouseEventArgs e)
        {
            Nigeria.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Nigeria_MouseLeave(object sender, MouseEventArgs e)
        {
            Nigeria.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Benin_MouseEnter(object sender, MouseEventArgs e)
        {
            Benin.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Benin_MouseLeave(object sender, MouseEventArgs e)
        {
            Benin.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Togo_MouseEnter(object sender, MouseEventArgs e)
        {
            Togo.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Togo_MouseLeave(object sender, MouseEventArgs e)
        {
            Togo.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Ghana_MouseEnter(object sender, MouseEventArgs e)
        {
            Ghana.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Ghana_MouseLeave(object sender, MouseEventArgs e)
        {
            Ghana.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void CoteDlvoire_MouseEnter(object sender, MouseEventArgs e)
        {
            CoteDlvoire.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void CoteDlvoire_MouseLeave(object sender, MouseEventArgs e)
        {
            CoteDlvoire.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Liberia_MouseEnter(object sender, MouseEventArgs e)
        {
            Liberia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Liberia_MouseLeave(object sender, MouseEventArgs e)
        {
            Liberia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void SierraLeone_MouseEnter(object sender, MouseEventArgs e)
        {
            SierraLeone.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void SierraLeone_MouseLeave(object sender, MouseEventArgs e)
        {
            SierraLeone.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Guinea_MouseEnter(object sender, MouseEventArgs e)
        {
            Guinea.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Guinea_MouseLeave(object sender, MouseEventArgs e)
        {
            Guinea.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void GuineBissau_MouseEnter(object sender, MouseEventArgs e)
        {
            GuineBissau.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void GuineBissau_MouseLeave(object sender, MouseEventArgs e)
        {
            GuineBissau.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Senegal_MouseEnter(object sender, MouseEventArgs e)
        {
            Senegal.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Senegal_MouseLeave(object sender, MouseEventArgs e)
        {
            Senegal.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Gambia_MouseEnter(object sender, MouseEventArgs e)
        {
            Gambia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Gambia_MouseLeave(object sender, MouseEventArgs e)
        {
            Gambia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void BurkinaFaso_MouseEnter(object sender, MouseEventArgs e)
        {
            BurkinaFaso.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void BurkinaFaso_MouseLeave(object sender, MouseEventArgs e)
        {
            BurkinaFaso.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Niger_MouseEnter(object sender, MouseEventArgs e)
        {
            Niger.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Niger_MouseLeave(object sender, MouseEventArgs e)
        {
            Niger.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Chad_MouseEnter(object sender, MouseEventArgs e)
        {
            Tсhad.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Chad_MouseLeave(object sender, MouseEventArgs e)
        {
            Tсhad.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Sudan_MouseEnter(object sender, MouseEventArgs e)
        {
            Sudan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Sudan_MouseLeave(object sender, MouseEventArgs e)
        {
            Sudan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Egypt_MouseEnter(object sender, MouseEventArgs e)
        {
            Egypt.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Egypt_MouseLeave(object sender, MouseEventArgs e)
        {
            Egypt.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Libya_MouseEnter(object sender, MouseEventArgs e)
        {
            Libya.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Libya_MouseLeave(object sender, MouseEventArgs e)
        {
            Libya.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Tunisia_MouseEnter(object sender, MouseEventArgs e)
        {
            Tunisia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Tunisia_MouseLeave(object sender, MouseEventArgs e)
        {
            Tunisia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Algeria_MouseEnter(object sender, MouseEventArgs e)
        {
            Algeria.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Algeria_MouseLeave(object sender, MouseEventArgs e)
        {
            Algeria.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Morocco_MouseEnter(object sender, MouseEventArgs e)
        {
            Morocco.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Morocco_MouseLeave(object sender, MouseEventArgs e)
        {
            Morocco.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Mauritania_MouseEnter(object sender, MouseEventArgs e)
        {
            Mauritania.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Mauritania_MouseLeave(object sender, MouseEventArgs e)
        {
            Mauritania.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void WesternSahara_MouseEnter(object sender, MouseEventArgs e)
        {
            WesternSahara.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void WesternSahara_MouseLeave(object sender, MouseEventArgs e)
        {
            WesternSahara.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Mali_MouseEnter(object sender, MouseEventArgs e)
        {
            Mali.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Mali_MouseLeave(object sender, MouseEventArgs e)
        {
            Mali.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Portugal_MouseEnter(object sender, MouseEventArgs e)
        {
            Portugal.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Portugal_MouseLeave(object sender, MouseEventArgs e)
        {
            Portugal.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Spain_MouseEnter(object sender, MouseEventArgs e)
        {
            Spain.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Spain_MouseLeave(object sender, MouseEventArgs e)
        {
            Spain.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void PalmaDeMallorca_MouseEnter(object sender, MouseEventArgs e)
        {
            PalmaDeMallorca.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void PalmaDeMallorca_MouseLeave(object sender, MouseEventArgs e)
        {
            PalmaDeMallorca.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void France_MouseEnter(object sender, MouseEventArgs e)
        {
            France.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void France_MouseLeave(object sender, MouseEventArgs e)
        {
            France.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void UnitedKingdom_MouseEnter(object sender, MouseEventArgs e)
        {
            UnitedKingdom.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void UnitedKingdom_MouseLeave(object sender, MouseEventArgs e)
        {
            UnitedKingdom.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void IsleOfMan_MouseEnter(object sender, MouseEventArgs e)
        {
            IsleOfMan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void IsleOfMan_MouseLeave(object sender, MouseEventArgs e)
        {
            IsleOfMan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Belgium_MouseEnter(object sender, MouseEventArgs e)
        {
            Belgium.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Belgium_MouseLeave(object sender, MouseEventArgs e)
        {
            Belgium.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Netherlands_MouseEnter(object sender, MouseEventArgs e)
        {
            Netherlands.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Netherlands_MouseLeave(object sender, MouseEventArgs e)
        {
            Netherlands.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Ireland_MouseEnter(object sender, MouseEventArgs e)
        {
            Ireland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Ireland_MouseLeave(object sender, MouseEventArgs e)
        {
            Ireland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Germany_MouseEnter(object sender, MouseEventArgs e)
        {
            Germany.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Germany_MouseLeave(object sender, MouseEventArgs e)
        {
            Germany.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Switzerland_MouseEnter(object sender, MouseEventArgs e)
        {
            Switzerland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Switzerland_MouseLeave(object sender, MouseEventArgs e)
        {
            Switzerland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Italy_MouseEnter(object sender, MouseEventArgs e)
        {
            Italy.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Italy_MouseLeave(object sender, MouseEventArgs e)
        {
            Italy.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Malta_MouseEnter(object sender, MouseEventArgs e)
        {
            Malta.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Malta_MouseLeave(object sender, MouseEventArgs e)
        {
            Malta.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Malta1_MouseEnter(object sender, MouseEventArgs e)
        {
            Malta1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Malta1_MouseLeave(object sender, MouseEventArgs e)
        {
            Malta1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Austria_MouseEnter(object sender, MouseEventArgs e)
        {
            Austria.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Austria_MouseLeave(object sender, MouseEventArgs e)
        {
            Austria.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void CzechRepublic_MouseEnter(object sender, MouseEventArgs e)
        {
            CzechRepublic.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void CzechRepublic_MouseLeave(object sender, MouseEventArgs e)
        {
            CzechRepublic.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Denmark_MouseEnter(object sender, MouseEventArgs e)
        {
            Denmark.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Denmark_MouseLeave(object sender, MouseEventArgs e)
        {
            Denmark.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Denmark1_MouseEnter(object sender, MouseEventArgs e)
        {
            Denmark1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Denmark1_MouseLeave(object sender, MouseEventArgs e)
        {
            Denmark1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Poland_MouseEnter(object sender, MouseEventArgs e)
        {
            Poland.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Poland_MouseLeave(object sender, MouseEventArgs e)
        {
            Poland.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Belarus_MouseEnter(object sender, MouseEventArgs e)
        {
            Belarus.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Belarus_MouseLeave(object sender, MouseEventArgs e)
        {
            Belarus.Fill = new SolidColorBrush(Colors.LightGray);
        }

      
        private void Russia1_MouseEnter(object sender, MouseEventArgs e)
        {
            Russia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Russia1_MouseLeave(object sender, MouseEventArgs e)
        {
            Russia1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Lithuania_MouseEnter(object sender, MouseEventArgs e)
        {
            Lithuania.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Lithuania_MouseLeave(object sender, MouseEventArgs e)
        {
            Lithuania.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Latvia_MouseEnter(object sender, MouseEventArgs e)
        {
            Latvia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Latvia_MouseLeave(object sender, MouseEventArgs e)
        {
            Latvia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Estonia_MouseEnter(object sender, MouseEventArgs e)
        {
            Estonia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Estonia_MouseLeave(object sender, MouseEventArgs e)
        {
            Estonia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Romania_MouseEnter(object sender, MouseEventArgs e)
        {
            Romania.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Romania_MouseLeave(object sender, MouseEventArgs e)
        {
            Romania.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Ukraine_MouseEnter(object sender, MouseEventArgs e)
        {
            Ukraine.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Ukraine_MouseLeave(object sender, MouseEventArgs e)
        {
            Ukraine.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Moldova_MouseEnter(object sender, MouseEventArgs e)
        {
            Moldova.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Moldova_MouseLeave(object sender, MouseEventArgs e)
        {
            Moldova.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Slovakia_MouseEnter(object sender, MouseEventArgs e)
        {
            Slovakia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Slovakia_MouseLeave(object sender, MouseEventArgs e)
        {
            Slovakia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Hungary_MouseEnter(object sender, MouseEventArgs e)
        {
            Hungary.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Hungary_MouseLeave(object sender, MouseEventArgs e)
        {
            Hungary.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Slovenia_MouseEnter(object sender, MouseEventArgs e)
        {
            Slovenia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Slovenia_MouseLeave(object sender, MouseEventArgs e)
        {
            Slovenia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Croatia_MouseEnter(object sender, MouseEventArgs e)
        {
            Croatia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Croatia_MouseLeave(object sender, MouseEventArgs e)
        {
            Croatia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Serbia_MouseEnter(object sender, MouseEventArgs e)
        {
            Serbia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Serbia_MouseLeave(object sender, MouseEventArgs e)
        {
            Serbia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void BosniaAndHerzegovina_MouseEnter(object sender, MouseEventArgs e)
        {
            BosniaAndHerzegovina.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void BosniaAndHerzegovina_MouseLeave(object sender, MouseEventArgs e)
        {
            BosniaAndHerzegovina.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Montenegro_MouseEnter(object sender, MouseEventArgs e)
        {
            Montenegro.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Montenegro_MouseLeave(object sender, MouseEventArgs e)
        {
            Montenegro.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Albania_MouseEnter(object sender, MouseEventArgs e)
        {
            Albania.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Albania_MouseLeave(object sender, MouseEventArgs e)
        {
            Albania.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Greece_MouseEnter(object sender, MouseEventArgs e)
        {
            Greece.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Greece_MouseLeave(object sender, MouseEventArgs e)
        {
            Greece.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Macedonia_MouseEnter(object sender, MouseEventArgs e)
        {
            Macedonia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Macedonia_MouseLeave(object sender, MouseEventArgs e)
        {
            Macedonia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Bulgaria_MouseEnter(object sender, MouseEventArgs e)
        {
            Bulgaria.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Bulgaria_MouseLeave(object sender, MouseEventArgs e)
        {
            Bulgaria.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Turkey_MouseEnter(object sender, MouseEventArgs e)
        {
            Turkey.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Turkey_MouseLeave(object sender, MouseEventArgs e)
        {
            Turkey.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Turkey1_MouseEnter(object sender, MouseEventArgs e)
        {
            Turkey1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Turkey1_MouseLeave(object sender, MouseEventArgs e)
        {
            Turkey1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Cyprus_MouseEnter(object sender, MouseEventArgs e)
        {
            Cyprus.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Cyprus_MouseLeave(object sender, MouseEventArgs e)
        {
            Cyprus.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Syria_MouseEnter(object sender, MouseEventArgs e)
        {
            Syria.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Syria_MouseLeave(object sender, MouseEventArgs e)
        {
            Syria.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Lebanon_MouseEnter(object sender, MouseEventArgs e)
        {
            Lebanon.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Lebanon_MouseLeave(object sender, MouseEventArgs e)
        {
            Lebanon.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Jordan_MouseEnter(object sender, MouseEventArgs e)
        {
            Jordan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Jordan_MouseLeave(object sender, MouseEventArgs e)
        {
            Jordan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Israel_MouseEnter(object sender, MouseEventArgs e)
        {
            Israel.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Israel_MouseLeave(object sender, MouseEventArgs e)
        {
            Israel.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void SaudiArabia_MouseEnter(object sender, MouseEventArgs e)
        {
            SaudiArabia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void SaudiArabia_MouseLeave(object sender, MouseEventArgs e)
        {
            SaudiArabia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Iraq_MouseEnter(object sender, MouseEventArgs e)
        {
            Iraq.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Iraq_MouseLeave(object sender, MouseEventArgs e)
        {
            Iraq.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Yemen_MouseEnter(object sender, MouseEventArgs e)
        {
            Yemen.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Yemen_MouseLeave(object sender, MouseEventArgs e)
        {
            Yemen.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Oman_MouseEnter(object sender, MouseEventArgs e)
        {
            Oman.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Oman_MouseLeave(object sender, MouseEventArgs e)
        {
            Oman.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void UnitedArabEmirates_MouseEnter(object sender, MouseEventArgs e)
        {
            UnitedArabEmirates.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void UnitedArabEmirates_MouseLeave(object sender, MouseEventArgs e)
        {
            UnitedArabEmirates.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Qatar_MouseEnter(object sender, MouseEventArgs e)
        {
            Qatar.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Qatar_MouseLeave(object sender, MouseEventArgs e)
        {
            Qatar.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Kuwait_MouseEnter(object sender, MouseEventArgs e)
        {
            Kuwait.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Kuwait_MouseLeave(object sender, MouseEventArgs e)
        {
            Kuwait.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Georgia_MouseEnter(object sender, MouseEventArgs e)
        {
            Georgia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Georgia_MouseLeave(object sender, MouseEventArgs e)
        {
            Georgia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Armenia_MouseEnter(object sender, MouseEventArgs e)
        {
            Armenia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Armenia_MouseLeave(object sender, MouseEventArgs e)
        {
            Armenia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Azerbaijan_MouseEnter(object sender, MouseEventArgs e)
        {
            Azerbaijan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Azerbaijan_MouseLeave(object sender, MouseEventArgs e)
        {
            Azerbaijan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Iran_MouseEnter(object sender, MouseEventArgs e)
        {
            Iran.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Iran_MouseLeave(object sender, MouseEventArgs e)
        {
            Iran.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Turkmenistan_MouseEnter(object sender, MouseEventArgs e)
        {
            Turkmenistan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Turkmenistan_MouseLeave(object sender, MouseEventArgs e)
        {
            Turkmenistan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Afghanistan_MouseEnter(object sender, MouseEventArgs e)
        {
            Afghanistan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Afghanistan_MouseLeave(object sender, MouseEventArgs e)
        {
            Afghanistan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Uzbekistan_MouseEnter(object sender, MouseEventArgs e)
        {
            Uzbekistan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Uzbekistan_MouseLeave(object sender, MouseEventArgs e)
        {
            Uzbekistan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Tajikistan_MouseEnter(object sender, MouseEventArgs e)
        {
            Tajikistan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Tajikistan_MouseLeave(object sender, MouseEventArgs e)
        {
            Tajikistan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Kyrgyzstan_MouseEnter(object sender, MouseEventArgs e)
        {
            Kyrgyzstan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Kyrgyzstan_MouseLeave(object sender, MouseEventArgs e)
        {
            Kyrgyzstan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Pakistan_MouseEnter(object sender, MouseEventArgs e)
        {
            Pakistan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Pakistan_MouseLeave(object sender, MouseEventArgs e)
        {
            Pakistan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void India_MouseEnter(object sender, MouseEventArgs e)
        {
            India.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void India_MouseLeave(object sender, MouseEventArgs e)
        {
            India.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Nepal_MouseEnter(object sender, MouseEventArgs e)
        {
            Nepal.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Nepal_MouseLeave(object sender, MouseEventArgs e)
        {
            Nepal.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Bhutan_MouseEnter(object sender, MouseEventArgs e)
        {
            Bhutan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Bhutan_MouseLeave(object sender, MouseEventArgs e)
        {
            Bhutan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Bangladesh_MouseEnter(object sender, MouseEventArgs e)
        {
            Bangladesh.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Bangladesh_MouseLeave(object sender, MouseEventArgs e)
        {
            Bangladesh.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void MyanmarBurma_MouseEnter(object sender, MouseEventArgs e)
        {
            MyanmarBurma.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void MyanmarBurma_MouseLeave(object sender, MouseEventArgs e)
        {
            MyanmarBurma.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Thailand_MouseEnter(object sender, MouseEventArgs e)
        {
            Thailand.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Thailand_MouseLeave(object sender, MouseEventArgs e)
        {
            Thailand.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Malaysia_MouseEnter(object sender, MouseEventArgs e)
        {
            Malaysia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Malaysia_MouseLeave(object sender, MouseEventArgs e)
        {
            Malaysia.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Laos_MouseEnter(object sender, MouseEventArgs e)
        {
            Laos.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Laos_MouseLeave(object sender, MouseEventArgs e)
        {
            Laos.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Cambodia_MouseEnter(object sender, MouseEventArgs e)
        {
            Cambodia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Cambodia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Cambodia_MouseLeave(object sender, MouseEventArgs e)
        {
            Cambodia.Fill = new SolidColorBrush(Colors.LightGray);
            Cambodia1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Vietnam_MouseEnter(object sender, MouseEventArgs e)
        {
            Vietnam.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Vietnam_MouseLeave(object sender, MouseEventArgs e)
        {
            Vietnam.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Hainan_MouseEnter(object sender, MouseEventArgs e)
        {
            Hainan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Hainan_MouseLeave(object sender, MouseEventArgs e)
        {
            Hainan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void NorthKorea_MouseEnter(object sender, MouseEventArgs e)
        {
            NorthKorea.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void NorthKorea_MouseLeave(object sender, MouseEventArgs e)
        {
            NorthKorea.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void SouthKorea_MouseEnter(object sender, MouseEventArgs e)
        {
            SouthKorea.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void SouthKorea_MouseLeave(object sender, MouseEventArgs e)
        {
            SouthKorea.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Taiwan_MouseEnter(object sender, MouseEventArgs e)
        {
            Taiwan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Taiwan_MouseLeave(object sender, MouseEventArgs e)
        {
            Taiwan.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Japan1_MouseEnter(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Japan1_MouseLeave(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightGray);
            Japan1.Fill = new SolidColorBrush(Colors.LightGray);
            Japan2.Fill = new SolidColorBrush(Colors.LightGray);
            Japan3.Fill = new SolidColorBrush(Colors.LightGray);
            Japan4.Fill = new SolidColorBrush(Colors.LightGray);

        }

        private void Japan2_MouseEnter(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Japan2_MouseLeave(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightGray);
            Japan1.Fill = new SolidColorBrush(Colors.LightGray);
            Japan2.Fill = new SolidColorBrush(Colors.LightGray);
            Japan3.Fill = new SolidColorBrush(Colors.LightGray);
            Japan4.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Japan_MouseEnter(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Japan_MouseLeave(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightGray);
            Japan1.Fill = new SolidColorBrush(Colors.LightGray);
            Japan2.Fill = new SolidColorBrush(Colors.LightGray);
            Japan3.Fill = new SolidColorBrush(Colors.LightGray);
            Japan4.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Japan3_MouseEnter(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Japan3_MouseLeave(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightGray);
            Japan1.Fill = new SolidColorBrush(Colors.LightGray);
            Japan2.Fill = new SolidColorBrush(Colors.LightGray);
            Japan3.Fill = new SolidColorBrush(Colors.LightGray);
            Japan4.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Japan4_MouseEnter(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Japan4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Japan4_MouseLeave(object sender, MouseEventArgs e)
        {
            Japan.Fill = new SolidColorBrush(Colors.LightGray);
            Japan1.Fill = new SolidColorBrush(Colors.LightGray);
            Japan2.Fill = new SolidColorBrush(Colors.LightGray);
            Japan3.Fill = new SolidColorBrush(Colors.LightGray);
            Japan4.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines_MouseLeave(object sender, MouseEventArgs e)
        {
            
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Indonesia_MouseEnter(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        


        }

        private void Indonesia_MouseLeave(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightGray);
        }


        private void Djibouti_MouseEnter(object sender, MouseEventArgs e)
        {
            Djibouti.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Djibouti_MouseLeave(object sender, MouseEventArgs e)
        {
            Djibouti.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Eritrea_MouseEnter(object sender, MouseEventArgs e)
        {
            Eritrea.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Eritrea_MouseLeave(object sender, MouseEventArgs e)
        {
            Eritrea.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada1_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada1_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);


        }

        private void Canada2_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada2_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada3_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada3_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada4_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada4_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada5_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada5_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada6_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada6_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada7_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada7_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada8_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada8_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada9_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada9_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada10_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada10_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Canada11_MouseEnter(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada8.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada9.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada10.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Canada11.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Canada11_MouseLeave(object sender, MouseEventArgs e)
        {
            Canada.Fill = new SolidColorBrush(Colors.LightGray);
            Canada1.Fill = new SolidColorBrush(Colors.LightGray);
            Canada2.Fill = new SolidColorBrush(Colors.LightGray);
            Canada3.Fill = new SolidColorBrush(Colors.LightGray);
            Canada4.Fill = new SolidColorBrush(Colors.LightGray);
            Canada5.Fill = new SolidColorBrush(Colors.LightGray);
            Canada6.Fill = new SolidColorBrush(Colors.LightGray);
            Canada7.Fill = new SolidColorBrush(Colors.LightGray);
            Canada8.Fill = new SolidColorBrush(Colors.LightGray);
            Canada9.Fill = new SolidColorBrush(Colors.LightGray);
            Canada10.Fill = new SolidColorBrush(Colors.LightGray);
            Canada11.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void USA1_MouseEnter(object sender, MouseEventArgs e)
        {
            US.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            USA1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            USA.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void USA1_MouseLeave(object sender, MouseEventArgs e)
        {
            US.Fill = new SolidColorBrush(Colors.LightGray);
            USA1.Fill = new SolidColorBrush(Colors.LightGray);
            USA.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Singapore_MouseEnter(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Singapore_MouseLeave(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore2.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore3.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore4.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore5.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore6.Fill = new SolidColorBrush(Colors.LightGray);
          
        }

        private void Singapore6_MouseEnter(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Singapore6_MouseLeave(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore2.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore3.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore4.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore5.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore6.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Singapore3_MouseLeave(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore2.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore3.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore4.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore5.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore6.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Singapore3_MouseEnter(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Singapore2_MouseEnter(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Singapore2_MouseLeave(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore2.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore3.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore4.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore5.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore6.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Singapore5_MouseEnter(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Singapore5_MouseLeave(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore2.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore3.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore4.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore5.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore6.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Singapore4_MouseEnter(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Singapore6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Singapore4_MouseLeave(object sender, MouseEventArgs e)
        {
            Singapore.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore2.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore3.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore4.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore5.Fill = new SolidColorBrush(Colors.LightGray);
            Singapore6.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Cambodia1_MouseEnter(object sender, MouseEventArgs e)
        {
            Cambodia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Cambodia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Cambodia1_MouseLeave(object sender, MouseEventArgs e)
        {
            Cambodia.Fill = new SolidColorBrush(Colors.LightGray);
            Cambodia1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines1_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            

        }

        private void Philippines1_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines2_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines2_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines3_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines3_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines4_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines4_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines6_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines6_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines7_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines7_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Philippines5_MouseEnter(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines6.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Philippines7.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Philippines5_MouseLeave(object sender, MouseEventArgs e)
        {
            Philippines.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines1.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines2.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines3.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines4.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines5.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines6.Fill = new SolidColorBrush(Colors.LightGray);
            Philippines7.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Indonesia1_MouseEnter(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        
        }

        private void Indonesia1_MouseLeave(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Indonesia2_MouseEnter(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Indonesia2_MouseLeave(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Indonesia3_MouseEnter(object sender, MouseEventArgs e)
        {

            Indonesia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Indonesia3_MouseLeave(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Indonesia4_MouseEnter(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Indonesia4_MouseLeave(object sender, MouseEventArgs e)
        {

            Indonesia.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Indonesia5_MouseEnter(object sender, MouseEventArgs e)
        {
            Indonesia.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Indonesia5_MouseLeave(object sender, MouseEventArgs e)
        {

            Indonesia.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia1.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia2.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia3.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia4.Fill = new SolidColorBrush(Colors.LightGray);
            Indonesia5.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void PapuaNewGuinea_MouseEnter(object sender, MouseEventArgs e)
        {
            PapuaNewGuinea.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void PapuaNewGuinea_MouseLeave(object sender, MouseEventArgs e)
        {
            PapuaNewGuinea.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Hawaii_MouseEnter(object sender, MouseEventArgs e)
        {
            Hawaii.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Hawaii1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Hawaii_MouseLeave(object sender, MouseEventArgs e)
        {
            Hawaii.Fill = new SolidColorBrush(Colors.LightGray);
            Hawaii1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Hawaii1_MouseEnter(object sender, MouseEventArgs e)
        {
            Hawaii.Fill = new SolidColorBrush(Colors.LightSkyBlue);
            Hawaii1.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Hawaii1_MouseLeave(object sender, MouseEventArgs e)
        {
            Hawaii.Fill = new SolidColorBrush(Colors.LightGray);
            Hawaii1.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Cuba_MouseEnter(object sender, MouseEventArgs e)
        {
            Cuba.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Cuba_MouseLeave(object sender, MouseEventArgs e)
        {
            Cuba.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Jamaica_MouseEnter(object sender, MouseEventArgs e)
        {
            Jamaica.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Jamaica_MouseLeave(object sender, MouseEventArgs e)
        {
            Jamaica.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void Haiti_MouseEnter(object sender, MouseEventArgs e)
        {
            Haiti.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void Haiti_MouseLeave(object sender, MouseEventArgs e)
        {
            Haiti.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void DominicanRepublic_MouseEnter(object sender, MouseEventArgs e)
        {
            DominicanRepublic.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void DominicanRepublic_MouseLeave(object sender, MouseEventArgs e)
        {
            DominicanRepublic.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void PuartoRico_MouseEnter(object sender, MouseEventArgs e)
        {
            PuartoRico.Fill = new SolidColorBrush(Colors.LightSkyBlue);
        }

        private void PuartoRico_MouseLeave(object sender, MouseEventArgs e)
        {
            PuartoRico.Fill = new SolidColorBrush(Colors.LightGray);
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
            ViewManager form = new ViewManager();

            this.Close();
            form.Show();
        }


        private void minimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized; 
        }

        private void Grid_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }


        // Getting country names from txt file.
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
     

            cn.Open();                                                                      //Opens connection
            cmd = new SqlCommand("DELETE FROM countryStorageTb", cn);                                 //Deletes from the table
            cmd.ExecuteNonQuery();                                                          //Executes the cmd
            cn.Close();                     
            
            string stringPath = Singleton.relativeDirectory + @"\CountryName_copy.txt";

            // Insert Data from text file into data base
            cn.Open();
            cmd = new SqlCommand("BULK INSERT countryStorageTb FROM '" + stringPath + "' WITH (FIELDTERMINATOR = ',')", cn);
            cmd.ExecuteNonQuery();
            MessageBox.Show("DONE!");
            cn.Close();

            // Read from data base into list box
            cn.Open();
            cmd.CommandText = "Select country_name from countryStorageTb";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                CountryListBox.Items.Add(dr.GetString(0));
            }
            cn.Close();



          /*  string[] fileContents = File.ReadAllLines("CountryName.txt");
            CountryListBox.ItemsSource = fileContents;
           * */
        }

        // Click Respond from Map
        private void Countrys(int number)
        {
            CountryListBox.Focus();
            CountryListBox.SelectedIndex = number;
            CountryListBox.ScrollIntoView(CountryListBox.Items[CountryListBox.SelectedIndex]);
        }

        private void Afghanistan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(0);
        }

        private void Armenia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(5);
        }

        private void Mexico_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(97);
        }

        private void Iceland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(67);
        }

        private void Greenland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(57);
        }

        private void Taiwan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(146);
        }

        private void Mongolia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(99);
        }

        private void SouthKorea_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(137);
        }

        private void NorthKorea_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(111);
        }

        private void MyanmarBurma_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(103);
        }

        private void Laos_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(83);
        }

        private void Thailand_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(149);
        }

        private void Cambodia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(21);
        }

        private void Vietnam_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(161);
        }

        private void Bangladesh_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(8);
        }

        private void India_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(68);
        }

        private void Nepal_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(105);
        }

        private void Bhutan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(13);
        }

        private void Kazakhstan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(79);
        }

        private void Iran_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(70);
        }

        private void Turkmenistan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(153);
        }

        private void Pakistan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(114);
        }

        private void Uzbekistan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(159);
        }

        private void Tajikistan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(147);
        }

        private void Kyrgyzstan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(82);
        }

        private void Azerbaijan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(7);
        }

        private void Georgia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(53);
        }

        private void Latvia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(84);
        }

        private void Lithuania_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(89);
        }

        private void Belarus_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(9);
        }

        private void Estonia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(45);
        }

        private void Ukraine_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(154);
        }

        private void Sweden_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(143);
        }

        private void Norway_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(112);
        }

        private void Finland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(48);
        }

        private void Hungary_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(66);
        }

        private void Slovakia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(133);
        }

        private void Switzerland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(144);
        }

        private void CzechRepublic_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(35);
        }

        private void Portugal_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(122);
        }

        private void Moldova_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(98);
        }

        private void Poland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(121);
        }

        private void Romania_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(125);
        }

        private void Germany_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(54);
        }

        private void Austria_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(6);
        }

        private void Belgium_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(10);
        }

        private void Netherlands_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(106);
        }

        private void Ireland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(72);
        }

        private void Macedonia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(90);
        }

        private void Serbia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(130);
        }

        private void Slovenia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(134);
        }

        private void BosniaAndHerzegovina_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(15);
        }

        private void Greece_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(56);
        }

        private void Croatia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(32);
        }

        private void Montenegro_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(100);
        }

        private void Albania_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(1);
        }

        private void Bulgaria_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(18);
        }

        private void Qatar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(124);
        }

        private void Cyprus_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(34);
        }

        private void Jordan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(78);
        }

        private void SaudiArabia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(128);
        }

        private void Kuwait_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(81);
        }

        private void Iraq_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(71);
        }

        private void UnitedArabEmirates_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(155);
        }

        private void Oman_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(113);
        }

        private void Syria_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(145);
        }

        private void Yemen_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(164);
        }

        private void Lebanon_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(85);
        }

        private void Israel_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(74);
        }

        private void Madagascar_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(91);
        }

        private void Cameroun_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(22);
        }

        private void Gabon_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(51);
        }

        private void EquatorialGuinea_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(43);
        }

        private void Nigeria_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(110);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string Country;
            Country = CountryListBox.SelectedItem.ToString();
            cn.Open();
            cmd = new SqlCommand("Insert into peopleTb (current_location) values(@current_location)", cn);
            cmd.Parameters.AddWithValue("@current_location", Country);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Added!!!");
            cn.Close();
        }

        private void Malta1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(95);
        }

        private void Hainan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(62);
        }

        private void China_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(27);
        }

        private void Japan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(77);
        }

        private void Japan1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(77);
        }

        private void Japan2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(77);
        }

        private void Japan3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(77);
        }

        private void Philippines_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines7_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Philippines5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(120);
        }

        private void Indonesia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(69);
        }

        private void Singapore_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(132);
        }

        private void Singapore6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(132);
        }

        private void Singapore3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(132);
        }

        private void Singapore2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(132);
        }

        private void Singapore4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(132);
        }

        private void Indonesia1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(69);
        }

        private void Indonesia3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(69);
        }

        private void Indonesia2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(69);
        }

        private void Indonesia5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(69);
        }

        private void Indonesia4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(69);
        }

        private void Cambodia1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(21);
        }

        private void Malaysia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(93);
        }

        private void PapuaNewGuinea_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(117);
        }

        private void Hawaii_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(64);
        }

        private void Hawaii1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(64);
        }

        private void Japan4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(77);
        }

        private void Russia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(126);
        }

        private void Russia1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(126);
        }

        private void Denmark_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(36);
        }

        private void Denmark1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(36);
        }

        private void Malta_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(95);
        }

        private void Italy_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(75);
        }

        private void France_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(49);
        }

        private void UnitedKingdom_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(156);
        }

        private void IsleOfMan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(73);
        }

        private void Spain_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(139);
        }

        private void PalmaDeMallorca_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(115);
        }

        private void Turkey_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(152);
        }

        private void Turkey1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(152);
        }

        private void CoteDlvoire_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(31);
        }

        private void Liberia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(87);
        }

        private void Angola_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(3);
        }

        private void Ghana_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(55);
        }

        private void Congo_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(29);
        }

        private void Eritrea_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(44);
        }

        private void SierraLeone_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(131);
        }

        private void Djibouti_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(37);
        }

        private void Mozambique_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(102);
        }

        private void Somalia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(135);
        }

        private void Namibia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(104);
        }

        private void SouthAfrica_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(136);
        }

        private void Kenya_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(80);
        }

        private void Tanzania_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(148);
        }

        private void Mauritania_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(96);
        }

        private void Rwanda_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(127);
        }

        private void Burundi_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(20);
        }

        private void Guinea_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(60);
        }

        private void Mali_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(94);
        }

        private void Zambia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(164);
        }

        private void Botswana_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(16);
        }

        private void BurkinaFaso_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(19);
        }

        private void Malawi_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(92);
        }

        private void Ethiopia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(46);
        }

        private void SouthSudan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(138);
        }

        private void Niger_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(109);
        }

        private void WesternSahara_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(162);
        }

        private void Senegal_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(129);
        }

        private void Gambia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(52);
        }

        private void Tсhad_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(25);
        }

        private void Libya_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(88);
        }

        private void Morocco_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(101);
        }

        private void Algeria_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(2);
        }

        private void Tunisia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(151);
        }

        private void Zimbabwe_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(165);
        }

        private void Lesotho_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(86);
        }

        private void Swaziland_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(142);
        }

        private void Egypt_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(41);
        }

        private void Sudan_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(140);
        }

        private void DRCongo_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(39);
        }

        private void RepubliqueCentrafricaine_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(24);
        }

        private void Benin_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(12);
        }

        private void Togo_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(150);
        }

        private void GuineBissau_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(59);
        }

        private void US_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(158);
        }

        private void USA_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(158);
        }

        private void USA1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(158);
        }

        private void Canada_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada11_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada4_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada7_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada8_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada6_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada5_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada3_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada1_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada2_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada10_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Canada9_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(23);
        }

        private void Cuba_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(33);
        }

        private void Jamaica_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(76);
        }

        private void PuartoRico_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(123);
        }

        private void Guatemala_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(58);
        }

        private void Honduras_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(65);
        }

        private void ElSalvador_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(42);
        }

        private void Belize_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(11);
        }

        private void Nicaragua_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(108);
        }

        private void Ecuador_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(40);
        }

        private void Columbia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(28);
        }

        private void FalklandIslands_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(47);
        }

        private void Argentina_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(4);
        }

        private void Uruguay_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(157);
        }

        private void Venezuela_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(160);
        }

        private void CostaRica_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(30);
        }

        private void Guyana_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(61);
        }

        private void Bolivia_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(14);
        }

        private void FrenchGuiana_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(50);
        }

        private void Paraguay_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(118);
        }

        private void Suriname_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(141);
        }

        private void Brazil_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(17);
        }

        private void Panama_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(116);
        }

        private void Peru_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(119);
        }

        private void Chile_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(26);
        }

        private void DominicanRepublic_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(38);
        }

        private void Haiti_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
        	Countrys(63);
        }

  
    }
}
