using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Solicitante;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Solicitante
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class SolicitanteService : ISolicitanteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Solicitante.Solicitante> _SolicitanteRepository;
        #endregion

        #region Ctor
        public SolicitanteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Solicitante.Solicitante> SolicitanteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._SolicitanteRepository = SolicitanteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAll(bool ConRelaciones)
        {
            return this._SolicitanteRepository.Table.ToList();
        }

        public IList<Core.Domain.Solicitante.Solicitante> SelAllComplete(bool ConRelaciones)
        {
            return this._SolicitanteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._SolicitanteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitante.Solicitante> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._SolicitanteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Solicitante.Solicitante> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._SolicitanteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitante.SolicitantePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            SolicitantePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Solicitante.Solicitante> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._SolicitanteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Solicitante.Solicitante GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Solicitante.Solicitante result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData SolicitanteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Solicitante.Solicitante entity, Spartane.Core.Domain.User.GlobalData SolicitanteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Solicitante.Solicitante entity, Spartane.Core.Domain.User.GlobalData SolicitanteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

