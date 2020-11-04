using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Expediente_Inicial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Expediente_Inicial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Expediente_InicialService : IExpediente_InicialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> _Expediente_InicialRepository;
        #endregion

        #region Ctor
        public Expediente_InicialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> Expediente_InicialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Expediente_InicialRepository = Expediente_InicialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAll(bool ConRelaciones)
        {
            return this._Expediente_InicialRepository.Table.ToList();
        }

        public IList<Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAllComplete(bool ConRelaciones)
        {
            return this._Expediente_InicialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Expediente_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Expediente_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Expediente_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Expediente_Inicial.Expediente_InicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Expediente_InicialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Expediente_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Expediente_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Expediente_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Expediente_Inicial.Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Expediente_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

