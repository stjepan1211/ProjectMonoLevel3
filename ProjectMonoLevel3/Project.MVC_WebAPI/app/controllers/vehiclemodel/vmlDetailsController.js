angular.module('vehicleApp').controller('vmlDetailsController', ['$scope', '$http', '$stateParams', '$window', vmlDetailsController]);

function vmlDetailsController($scope, $http, $stateParams, $window) {
    
    $scope.detailsData = {
        VehicleModelId: undefined,
        VehicleMakeId: undefined,
        Name: undefined,
        Abrv: undefined
    };

    $http.get('/api/VehicleModel/GetVml?id=' + $stateParams.VmlId)
        .success(function (data) {
            $scope.detailsData = data;
        })
    $scope.ispis = function () {
        return $window.alert($stateParams.VmlId + "");
    }
}                                                                                                                                                                                                                   