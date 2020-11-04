using System;
using System.Data;
using Spartane.Core;
using Spartane.Core.Data;
using Spartane.Data.EF;
using Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo;
using System.Collections.Generic;
using System.Linq;
using Spartane.Core.Exceptions;
using Spartane.Core.Exceptions.Service;
using System.Linq.Dynamic;

namespace Spartane.Services.Modalidad_de_Robo_de_Vehiculo
{
    /// <summary>
    /// Authentication Service
    /// </summary>
    public partial class Modalidad_de_Robo_de_VehiculoService : IModalidad_de_Robo_de_VehiculoService
    {
        #region Fields
        private readonly IDataProvider _dataProvider;
        private readonly IDbContext _dbContext;
        private readonly IRepository<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> _Modalidad_de_Robo_de_VehiculoRepository;
        #endregion

        #region Ctor
        public Modalidad_de_Robo_de_VehiculoService(IDataProvider dataProvider, IDbContext dbContext, IRepository<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> Modalidad_de_Robo_de_VehiculoRepository)
        {
            this._dataProvider = dataProvider;
            this._dbContext = dbContext;
            this._Modalidad_de_Robo_de_VehiculoRepository = Modalidad_de_Robo_de_VehiculoRepository;
        }
        #endregion

        #region CRUD Operations
        public int SelCount()
        {
            return 0;
        }

        public IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAll(bool ConRelaciones)
        {
            return this._Modalidad_de_Robo_de_VehiculoRepository.Table.ToList();
        }

        public IList<Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAllComplete(bool ConRelaciones)
        {
            return this._Modalidad_de_Robo_de_VehiculoRepository.Table.ToList();
        }

        public int ListaSelAllCount(string Where)
        {
            return 0;
        }


        public IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modalidad_de_Robo_de_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> SelAll(bool ConRelaciones, int CurrentRecordInt32, int RecordsDisplayedInt32)
        {
            return this._Modalidad_de_Robo_de_VehiculoRepository.Table.ToList();
        }

        public IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> ListaSelAll(bool ConRelaciones, string Where, string Order)
        {
            return this._Modalidad_de_Robo_de_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_VehiculoPagingModel ListaSelAll(int startRowIndex, int maximumRows, string Where, string Order)
        {
            Modalidad_de_Robo_de_VehiculoPagingModel result = null;
            return result;
        }

        public IList<Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo> ListaSelAll(bool ConRelaciones, string Where)
        {
            return this._Modalidad_de_Robo_de_VehiculoRepository.Table.ToList();
        }

        public Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo GetByKey(short Key, bool ConRelaciones)
        {
            Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo result=null;
            return result;
        }

        public bool Delete(short Key, Spartane.Core.Domain.User.GlobalData Modalidad_de_Robo_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            var rta = true;
            return rta;
        }

        public short Insert(Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Modalidad_de_Robo_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }

        public short Update(Spartane.Core.Domain.Modalidad_de_Robo_de_Vehiculo.Modalidad_de_Robo_de_Vehiculo entity, Spartane.Core.Domain.User.GlobalData Modalidad_de_Robo_de_VehiculoInformation, Core.Domain.Data.DataLayerFieldsBitacora DataReference)
        {
            short rta = Convert.ToInt16("0");
            return rta;
        }
        #endregion
    }
}

