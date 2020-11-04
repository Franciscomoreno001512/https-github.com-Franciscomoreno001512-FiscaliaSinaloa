using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Aseguradora_de_Vehiculo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Aseguradora_de_Vehiculo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Aseguradora_de_VehiculoService : IAseguradora_de_VehiculoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> _Aseguradora_de_VehiculoRepository;
        #endregion

        #region Ctor
        public Aseguradora_de_VehiculoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> Aseguradora_de_VehiculoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Aseguradora_de_VehiculoRepository = Aseguradora_de_VehiculoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAll(bool ConRelaciones)
        {
            return this._Aseguradora_de_VehiculoRepository.Table.ToList();
        }

        public IList<Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAllComplete(bool ConRelaciones)
        {
            return this._Aseguradora_de_VehiculoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Aseguradora_de_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Aseguradora_de_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Aseguradora_de_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Aseguradora_de_VehiculoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Aseguradora_de_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo GetByKey(int Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo result=null;
            return result;
        }

        public bool Delete(int Key, Spartane.Core.Domain.User.GlobalData Aseguradora_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public int Insert(Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Aseguradora_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }

        public int Update(Spartane.Core.Domain.Aseguradora_de_Vehiculo.Aseguradora_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Aseguradora_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            int rta = Convert.ToInt32("0");
            return rta;
        }
        #endregion
    }
}

