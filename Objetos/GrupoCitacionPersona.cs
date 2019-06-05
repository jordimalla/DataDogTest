
namespace Objetos
{
    public class GrupoCitacionPersona
    {
        public System.Int32 id { get; set; }
        public System.Boolean del { get; set; }
        public System.Int32 GrupoCitacion_id { get; set; }
        public System.String Hash { get; set; }
        public System.String PersonaNom { get; set; }
        public System.String PersonaCognom1 { get; set; }
        public System.String PersonaCognom2 { get; set; }
        public System.String PersonaDni { get; set; }
        public System.Boolean PersonaEsPassaport { get; set; }
        public System.String PersonaIdioma { get; set; }
        public System.String PersonaEmail { get; set; }
        public System.DateTime PersonaDataNaix { get; set; }
        public System.String PersonaGenere { get; set; }
        public System.Int32 PersonaLlocTreball { get; set; }
        public System.String PersonaLlocTreballAltres { get; set; }
        public System.Boolean PersonaLlocTreballConforme { get; set; }
        public System.Int32 CentreTreball { get; set; }
        public System.DateTime FechaPrevistaCita { get; set; }
        public System.Boolean RenunciaRM { get; set; }
        public System.String Origen { get; set; }
        public System.Int32 PersonaCreacion_id { get; set; }
        public System.Boolean EnvioInicial { get; set; }
        public System.String PersonaTelefono { get; set; }
        public System.String PersonaTelefonoFijo { get; set; }
        public System.Boolean PersonaMesLlocs { get; set; }
    }
}