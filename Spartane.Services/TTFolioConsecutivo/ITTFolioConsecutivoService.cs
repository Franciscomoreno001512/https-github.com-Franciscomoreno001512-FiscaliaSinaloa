using System;
using Spartane.Core.Domain.TTFolioConsecutivo;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.TTFolioConsecutivo
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ITTFolioConsecutivoService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.TTFolioConsecutivo.TTFolioConsecutivo> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
