using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Audiencia_Inicial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Audiencia_Inicial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Audiencia_InicialService : IAudiencia_InicialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> _Audiencia_InicialRepository;
        #endregion

        #region Ctor
        public Audiencia_InicialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> Audiencia_InicialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Audiencia_InicialRepository = Audiencia_InicialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> SelAll(bool ConRelaciones)
        {
            return this._Audiencia_InicialRepository.Table.ToList();
        }

        public IList<Core.Domain.Audiencia_Inicial.Audiencia_Inicial> SelAllComplete(bool ConRelaciones)
        {
            return this._Audiencia_InicialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Audiencia_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Audiencia_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_Inicial.Audiencia_InicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Audiencia_InicialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Audiencia_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Audiencia_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial entity, Spartane.Core.Domain.User.GlobalData Audiencia_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Audiencia_Inicial.Audiencia_Inicial entity, Spartane.Core.Domain.User.GlobalData Audiencia_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

