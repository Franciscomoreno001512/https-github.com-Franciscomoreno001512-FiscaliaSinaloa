using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Estatus_Orientador;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Estatus_Orientador
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Estatus_OrientadorService : IEstatus_OrientadorService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> _Estatus_OrientadorRepository;
        #endregion

        #region Ctor
        public Estatus_OrientadorService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> Estatus_OrientadorRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Estatus_OrientadorRepository = Estatus_OrientadorRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAll(bool ConRelaciones)
        {
            return this._Estatus_OrientadorRepository.Table.ToList();
        }

        public IList<Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAllComplete(bool ConRelaciones)
        {
            return this._Estatus_OrientadorRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_OrientadorRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Estatus_OrientadorRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Estatus_OrientadorRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_Orientador.Estatus_OrientadorPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Estatus_OrientadorPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Estatus_OrientadorRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Estatus_OrientadorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador entity, Spartane.Core.Domain.User.GlobalData Estatus_OrientadorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Estatus_Orientador.Estatus_Orientador entity, Spartane.Core.Domain.User.GlobalData Estatus_OrientadorInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

