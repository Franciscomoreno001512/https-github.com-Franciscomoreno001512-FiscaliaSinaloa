using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Otras_Identificaciones_Solicitante_MASC
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Otras_Identificaciones_Solicitante_MASCService : IOtras_Identificaciones_Solicitante_MASCService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> _Otras_Identificaciones_Solicitante_MASCRepository;
        #endregion

        #region Ctor
        public Otras_Identificaciones_Solicitante_MASCService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> Otras_Identificaciones_Solicitante_MASCRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Otras_Identificaciones_Solicitante_MASCRepository = Otras_Identificaciones_Solicitante_MASCRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> SelAll(bool ConRelaciones)
        {
            return this._Otras_Identificaciones_Solicitante_MASCRepository.Table.ToList();
        }

        public IList<Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> SelAllComplete(bool ConRelaciones)
        {
            return this._Otras_Identificaciones_Solicitante_MASCRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Otras_Identificaciones_Solicitante_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Otras_Identificaciones_Solicitante_MASCRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Otras_Identificaciones_Solicitante_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASCPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Otras_Identificaciones_Solicitante_MASCPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Otras_Identificaciones_Solicitante_MASCRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Otras_Identificaciones_Solicitante_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC entity, Spartane.Core.Domain.User.GlobalData Otras_Identificaciones_Solicitante_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Otras_Identificaciones_Solicitante_MASC.Otras_Identificaciones_Solicitante_MASC entity, Spartane.Core.Domain.User.GlobalData Otras_Identificaciones_Solicitante_MASCInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

