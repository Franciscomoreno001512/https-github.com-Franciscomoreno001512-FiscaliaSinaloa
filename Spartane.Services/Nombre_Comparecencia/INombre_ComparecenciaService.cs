﻿using System;
using Spartane.Core.Domain.Nombre_Comparecencia;
using System.Collections.Generic;
using Spartane.Core.Domain.Data;

namespace Spartane.Services.Nombre_Comparecencia
{
    /// <summary>
    /// Authentificated Service
    /// </summary>
    public partial interface INombre_ComparecenciaService
    {
        Int32 SelCount();
        IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAll(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAllComplete(Boolean ConRelaciones);
        IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAll(Boolean ConRelaciones, Int32 CurrentRecordInt32, Int32 RecordsDisplayedInt32);
        Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia GetByKey(int Key, Boolean ConRelaciones);
        bool Delete(int Key, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Insert(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        Int32 Update(Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia entity, Spartane.Core.Domain.User.GlobalData EmpleadoInformation, DataLayerFieldsBitacora DataReference);
        IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> SelAll(Boolean ConRelaciones, string Where, string Order);
        IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> ListaSelAll(Boolean ConRelaciones, string Where, string Order);
        Spartane.Core.Domain.Nombre_Comparecencia.Nombre_ComparecenciaPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order);
        int ListaSelAllCount(string Where);
        IList<Spartane.Core.Domain.Nombre_Comparecencia.Nombre_Comparecencia> ListaSelAll(Boolean ConRelaciones, string Where);
    }
}
