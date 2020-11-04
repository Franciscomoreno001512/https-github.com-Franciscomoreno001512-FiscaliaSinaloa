using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Elemento_Robado;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Elemento_Robado
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Elemento_RobadoService : IElemento_RobadoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> _Elemento_RobadoRepository;
        #endregion

        #region Ctor
        public Elemento_RobadoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> Elemento_RobadoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Elemento_RobadoRepository = Elemento_RobadoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAll(bool ConRelaciones)
        {
            return this._Elemento_RobadoRepository.Table.ToList();
        }

        public IList<Core.Domain.Elemento_Robado.Elemento_Robado> SelAllComplete(bool ConRelaciones)
        {
            return this._Elemento_RobadoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Elemento_RobadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Elemento_RobadoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Elemento_RobadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Elemento_Robado.Elemento_RobadoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Elemento_RobadoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Elemento_Robado.Elemento_Robado> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Elemento_RobadoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Elemento_Robado.Elemento_Robado GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Elemento_Robado.Elemento_Robado result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Elemento_RobadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado entity, Spartane.Core.Domain.User.GlobalData Elemento_RobadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Elemento_Robado.Elemento_Robado entity, Spartane.Core.Domain.User.GlobalData Elemento_RobadoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

