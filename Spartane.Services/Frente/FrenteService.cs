using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Frente;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Frente
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class FrenteService : IFrenteService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Frente.Frente> _FrenteRepository;
        #endregion

        #region Ctor
        public FrenteService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Frente.Frente> FrenteRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._FrenteRepository = FrenteRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Frente.Frente> SelAll(bool ConRelaciones)
        {
            return this._FrenteRepository.Table.ToList();
        }

        public IList<Core.Domain.Frente.Frente> SelAllComplete(bool ConRelaciones)
        {
            return this._FrenteRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Frente.Frente> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._FrenteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Frente.Frente> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._FrenteRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Frente.Frente> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._FrenteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Frente.FrentePagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            FrentePagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Frente.Frente> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._FrenteRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Frente.Frente GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Frente.Frente result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData FrenteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Frente.Frente entity, Spartane.Core.Domain.User.GlobalData FrenteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Frente.Frente entity, Spartane.Core.Domain.User.GlobalData FrenteInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

