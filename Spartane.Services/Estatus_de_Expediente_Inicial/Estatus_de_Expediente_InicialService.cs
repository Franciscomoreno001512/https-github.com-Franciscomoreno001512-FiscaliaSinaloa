using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_de_Expediente_Inicial;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_de_Expediente_Inicial
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_de_Expediente_InicialService : IEstatus_de_Expediente_InicialService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> _Estatus_de_Expediente_InicialRepository;
        #endregion

        #region Ctor
        public Estatus_de_Expediente_InicialService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> Estatus_de_Expediente_InicialRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_de_Expediente_InicialRepository = Estatus_de_Expediente_InicialRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> SelAll(bool ConRelaciones)
        {
            return this._Estatus_de_Expediente_InicialRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_de_Expediente_InicialRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Expediente_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_de_Expediente_InicialRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_de_Expediente_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_InicialPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_de_Expediente_InicialPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_de_Expediente_InicialRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Estatus_de_Expediente_Inicial.Estatus_de_Expediente_Inicial entity, Spartane.Core.Domain.User.GlobalData Estatus_de_Expediente_InicialInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

