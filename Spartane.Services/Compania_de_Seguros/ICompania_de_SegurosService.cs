using System;
using Spartane.Core.Domain.Compania_de_Seguros;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Compania_de_Seguros
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICompania_de_SegurosService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Compania_de_Seguros.Compania_de_SegurosPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Compania_de_Seguros.Compania_de_Seguros> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
