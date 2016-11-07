vehicleApp.controller('vehicleMakeController', function ($scope, $http) {
    $http.get('/GetAllVmk')
    .success(function (response) {
        $scope.vehicleMakes = response;
    })
    .error(function () {
        return "error";
    });
});
