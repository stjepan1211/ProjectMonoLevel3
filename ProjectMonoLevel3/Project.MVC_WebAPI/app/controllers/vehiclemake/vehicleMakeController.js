vehicleApp.controller('vehicleMakeController', function ($scope, $http, $rootScope) {

    $scope.getAllVmk = function () {
        $http.get('/api/VehicleMake/GetAllVmk')
        .success(function (response) {
            $scope.vehicleMakes = response;
        })
        .error(function () {
            return "error";
        });
    }
});
