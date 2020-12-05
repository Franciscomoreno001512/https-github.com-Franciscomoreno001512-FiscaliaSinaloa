using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Tribunal_de_Enjuiciamiento;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Tribunal_de_Enjuiciamiento
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Tribunal_de_EnjuiciamientoService : ITribunal_de_EnjuiciamientoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> _Tribunal_de_EnjuiciamientoRepository;
        #endregion

        #region Ctor
        public Tribunal_de_EnjuiciamientoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> Tribunal_de_EnjuiciamientoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Tribunal_de_EnjuiciamientoRepository = Tribunal_de_EnjuiciamientoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAll(bool ConRelaciones)
        {
            return this._Tribunal_de_EnjuiciamientoRepository.Table.ToList();
        }

        public IList<Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAllComplete(bool ConRelaciones)
        {
            return this._Tribunal_de_EnjuiciamientoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tribunal_de_EnjuiciamientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Tribunal_de_EnjuiciamientoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Tribunal_de_EnjuiciamientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_EnjuiciamientoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Tribunal_de_EnjuiciamientoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Tribunal_de_EnjuiciamientoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Spartane.Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Tribunal_de_Enjuiciamiento.Tribunal_de_Enjuiciamiento entity, Spartane.Core.Domain.User.GlobalData Tribunal_de_EnjuiciamientoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

