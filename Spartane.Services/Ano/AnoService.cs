using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Ano;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Ano
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class AnoService : IAnoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Ano.Ano> _AnoRepository;
        #endregion

        #region Ctor
        public AnoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Ano.Ano> AnoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._AnoRepository = AnoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Ano.Ano> SelAll(bool ConRelaciones)
        {
            return this._AnoRepository.Table.ToList();
        }

        public IList<Core.Domain.Ano.Ano> SelAllComplete(bool ConRelaciones)
        {
            return this._AnoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Ano.Ano> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AnoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ano.Ano> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._AnoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Ano.Ano> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._AnoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ano.AnoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            AnoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Ano.Ano> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._AnoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Ano.Ano GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Ano.Ano result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData AnoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Ano.Ano entity, Spartane.Core.Domain.User.GlobalData AnoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Ano.Ano entity, Spartane.Core.Domain.User.GlobalData AnoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

