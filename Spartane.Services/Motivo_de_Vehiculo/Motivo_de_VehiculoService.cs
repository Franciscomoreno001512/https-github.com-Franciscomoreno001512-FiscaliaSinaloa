using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Motivo_de_Vehiculo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Motivo_de_Vehiculo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Motivo_de_VehiculoService : IMotivo_de_VehiculoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> _Motivo_de_VehiculoRepository;
        #endregion

        #region Ctor
        public Motivo_de_VehiculoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> Motivo_de_VehiculoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Motivo_de_VehiculoRepository = Motivo_de_VehiculoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> SelAll(bool ConRelaciones)
        {
            return this._Motivo_de_VehiculoRepository.Table.ToList();
        }

        public IList<Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> SelAllComplete(bool ConRelaciones)
        {
            return this._Motivo_de_VehiculoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_de_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Motivo_de_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Motivo_de_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Motivo_de_VehiculoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Motivo_de_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Motivo_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Motivo_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Motivo_de_Vehiculo.Motivo_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Motivo_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

