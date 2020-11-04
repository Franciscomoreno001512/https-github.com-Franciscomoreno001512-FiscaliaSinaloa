using System;
using Spartane.Core.Domain.Descarga_de_Archivo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Descarga_de_Archivo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface IDescarga_de_ArchivoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_ArchivoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Descarga_de_Archivo.Descarga_de_Archivo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
