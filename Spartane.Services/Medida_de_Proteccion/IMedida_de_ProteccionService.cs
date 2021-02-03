using System;
using Spartane.Core.Domain.Medida_de_Proteccion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Medida_de_Proteccion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMedida_de_ProteccionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_ProteccionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Medida_de_Proteccion.Medida_de_Proteccion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
