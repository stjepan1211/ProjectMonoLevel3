var vehicleApp = angular.module("vehicleApp", ['ui.router']);

vehicleApp.config(function ($stateProvider, $urlRouterProvider) {

    //$urlRouterProvider.otherwise('/vehicleMake');

    $stateProvider
        .state('vehicleMake', {
            url: '/vehicleMake',
            templateUrl: 'app/views/vehiclemake/indexVehicleMake.html'
        })
        .state('vehicleModel', {
            url: '/vehicleModel',
            templateUrl: 'app/views/vehiclemodel/indexVehicleModel.html',
        });
});

//primjer ui-routinga scotch.io/tutorials/angular-routing-using-ui-router
//i ovdje www.youtube.com/watch?v=2jnrl5aT3A8