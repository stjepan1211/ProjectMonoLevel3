var vehicleApp = angular.module('vehicleApp', ['ui.router']);

vehicleApp.config(function ($stateProvider) {

    //$urlRouterProvider.otherwise('/vehicleMake');

    $stateProvider
        .state('vehicleMake', {
            url: '/vehicleMake',
            controller: 'vehicleMakeController',
            views: {
                "root":  {
                    templateUrl: 'app/views/vehiclemake/indexVehicleMake.html',
                }
            }
        })
        .state('vehicleModel', {
            url: '/vehicleModel',
            controller: 'vehicleModelController',
            views: {
                "root": {
                    templateUrl: 'app/views/vehiclemodel/indexVehicleModel.html',
                }
            }
            
        })
        .state('vehicleMake.addVmk', {
            url: '/addVmk',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemake/addVehicleMake.html'
                }
            } 
        })
        .state('vehicleMake.detailsVmk', {
            url: '/detailsVmk/:VmkId',
            controller: 'vmkDetailsController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemake/detailsVehicleMake.html',
                }
            },
        })
        .state('vehicleMake.editVmk', {
            url: '/editVmk/:VmkId',
            controller: 'vmkEditController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemake/editVehicleMake.html',
                }
            }
        })
        .state('vehicleMake.deleteVmk', {
            url: '/deleteVmk/:VmkId',
            controller: 'vmkDeleteController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemake/deleteVehicleMake.html'
                }
            }
        })
        .state('vehicleModel.addVml', {
            url: '/addVml/:VmkId',
            controller: 'vmlAddController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemodel/addVehicleModel.html'
                }
            }
        })
        .state('vehicleModel.editVml', {
            url: '/editVml/:VmlId',
            controller: 'vmlEditController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemodel/editVehicleModel.html',
                }
            }
        })
        .state('vehicleModel.detailsVml', {
            url: '/detailsVml/:VmlId',
            controller: 'vmlDetailsController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemodel/detailsVehicleModel.html',
                }
            },
        })
        .state('vehicleModel.deleteVml', {
            url: '/deleteVml/:VmlId',
            controller: 'vmlDeleteController',
            views: {
                "child": {
                    templateUrl: 'app/views/vehiclemodel/deleteVehicleModel.html'
                }
            }
        })
});
