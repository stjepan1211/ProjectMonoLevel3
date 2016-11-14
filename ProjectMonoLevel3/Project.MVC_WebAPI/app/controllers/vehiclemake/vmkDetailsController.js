angular.module('vehicleApp').controller('vmkDetailsController', ['$scope', '$http', '$stateParams', '$window', vmkDetailsController]);

function vmkDetailsController($scope, $http, $stateParams, $window) {

    $http.get('/api/VehicleMake/GetVmk?id=' + $stateParams.VmkId)
        .success(function (data) {
            $scope.detailsData = data;
        })

        .error(function (data) {
            $window.alert("Error " + data.message);
        })
}