using System;
using Spartane.Core.Domain.Calibre_de_Arma;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Calibre_de_Arma
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface ICalibre_de_ArmaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma GetByKey(short Key, Boolean ConRelaciones);
        bool Delete(short Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Insert(Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int16 Update(Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_ArmaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Calibre_de_Arma.Calibre_de_Arma> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
