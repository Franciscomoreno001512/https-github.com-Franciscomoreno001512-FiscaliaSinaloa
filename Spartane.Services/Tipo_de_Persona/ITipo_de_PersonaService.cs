using System;
using Spartane.Core.Domain.Tipo_de_Persona;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Tipo_de_Persona
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITipo_de_PersonaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_PersonaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Tipo_de_Persona.Tipo_de_Persona> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
