vehicleApp.controller('vehicleModelController', function ($scope, $http) {
    $scope.getAll = function() {
        $http.get('/api/VehicleModel/getAllVml')
        .success(function (response) {
            $scope.vehicleModels = response;
        })
        .error(function () {
            return "error";
        });
    }
});