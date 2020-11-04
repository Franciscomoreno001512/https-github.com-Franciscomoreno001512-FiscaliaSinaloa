using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modulo_Atencion_Inicial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modulo_Atencion_Inicial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modulo_Atencion_InicialService : IModulo_Atencion_InicialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> _Modulo_Atencion_InicialRepository;
        #endregion

        #region Ctor
        public Modulo_Atencion_InicialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> Modulo_Atencion_InicialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modulo_Atencion_InicialRepository = Modulo_Atencion_InicialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAll(bool ConRelaciones)
        {
            return this._Modulo_Atencion_InicialRepository.Table.ToList();
        }

        public IList<Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAllComplete(bool ConRelaciones)
        {
            return this._Modulo_Atencion_InicialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modulo_Atencion_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modulo_Atencion_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modulo_Atencion_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_InicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modulo_Atencion_InicialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modulo_Atencion_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Modulo_Atencion_Inicial.Modulo_Atencion_Inicial entity, Spartane.Core.Domain.User.GlobalData Modulo_Atencion_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

