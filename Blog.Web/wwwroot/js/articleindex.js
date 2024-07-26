$(document).ready(function () {
    $('#articleTables').DataTable({
        dom:
            "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
        ],
        language: {
            "sDecimal": ",",
            "sEmptyTable": "There is no data in the table.",
            "sInfo": "_Showing records from _START_ to _END_ from TOTAL_ record",
            "sInfoEmpty": "No record",
            "sInfoFiltered": "(found in _MAX_ record)",
            "sInfoPostFix": "",
            "sInfoThousands": ".",
            "sLengthMenu": "Show _MENU_ record on page",
            "sLoadingRecords": "Loading...",
            "sProcessing": "Processing...",
            "sSearch": "Ara:",
            "sZeroRecords": "No matching records found",
            "oPaginate": {
                "sFirst": "First",
                "sLast": "End",
                "sNext": "Next",
                "sPrevious": "Back"
            },
            "oAria": {
                "sSortAscending": ":enable ascending column sorting ",
                "sSortDescending": ": enable descending column sorting"
            },
            "select": {
                "rows": {
                    "_": "%d  record selected ",
                    "0": "",
                    "1": "1 record selected "
                }
            }
        }
    });
});