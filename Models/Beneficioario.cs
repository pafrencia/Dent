namespace Dent.Models
{
    public class Beneficiario
    {
        public int? constancia_id { get; set; }
        public int numero { get; set; }
        public string codigo { get; set; }
        public int beneficiario_id { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string numero_de_documento { get; set; }
        public string tipo_de_documento { get; set; }
        public string cuil_beneficiario { get; set; }
        public string cuil_titular { get; set; }
        public int ficha_os { get; set; }
        public int orden { get; set; }
        public string parentesco_denominacion { get; set; }
        public int parentesco_codigo { get; set; }
        public string delegacion_nombre { get; set; }
        public int delegacion_codigo { get; set; }
        public int estado { get; set; }
        public string fecha_de_nacimiento { get; set; }
        public int edad { get; set; }
        public bool plan_materno { get; set; }
        public bool plan_infantil { get; set; }
        public bool discapacidad { get; set; }
        public bool estudiante { get; set; }
        public string plan_descripcion { get; set; }
        public string plan_codigo { get; set; }
        public bool coseguro_exento { get; set; }
        public string sexo { get; set; }
        public List<object> coseguros { get; set; }
        public object fecha_de_baja { get; set; }
    }
}
