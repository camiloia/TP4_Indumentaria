public static class Equipos
{
    public static List<string> ListaEquipos{get;private set;}=new List<string>(){"1.River","2.Boca","3.Huracan","4.Tigre","5.Racing","6.San Lorenzo", "7.Banfield","8.Independiente","9.Velez","10.Argentinos Juniors"};
    public static List<string> ListaMedias{get;private set;}= new List<string>(){"Medias_Amarillas.jpg","medias_argentina.jpg","medias_azules.jpg","medias_blancas.jpg","medias_naranja.jpg","medias_negras.jpg","medias_rojas.png","Medias_rosas.jpg","medias_verdes.jpg","Medias_violetas.jpg"};
    public static List<string> ListaPantalones{get;private set;}=new List<string>(){"pantalon_amarillo.jpg","pantalon_argentina.jpg","pantalon_azul.jpg","pantalon_blanco.jpg","pantalon_naranja.jpg","pantalon_negro.jpg","pantalon_rojo.jpg","pantalon_rosa.jpg","pantalon_verde.jpg","pantalon_violeta.jpg"};
    public static List<string> ListaRemeras {get;private set;}=new List<string>(){"camiseta_amarillo.jpg","camiseta_argentina.jpg","Camiseta_azul_boca.png","Camiseta_azul_roja_tigre.png","camiseta_blanca.jpg","camiseta_naranja.jpg","Camiseta_roja.png","camiseta_rosa.png","camiseta_verde.jpg","camiseta_violeta.jpg"};
    static public Dictionary<string, Indumentaria> EquiposIndumentaria {get;private set;} = new Dictionary<string, Indumentaria>();

public static bool IngresarIndumentaria(string EquipoSeleccionado, Indumentaria item)
{
    bool devolver=false;
    if(EquiposIndumentaria.ContainsKey(EquipoSeleccionado))
    {
        devolver= true;
    }
    if(!devolver)
    {
        EquiposIndumentaria.Add(EquipoSeleccionado,item);
    }
    return devolver;
    
}
}

