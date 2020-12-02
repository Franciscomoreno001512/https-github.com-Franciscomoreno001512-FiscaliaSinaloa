using System;
using Spartane.Core.Domain.Metodo_de_Destruccion;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Metodo_de_Destruccion
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IMetodo_de_DestruccionService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_DestruccionPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Metodo_de_Destruccion.Metodo_de_Destruccion> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
