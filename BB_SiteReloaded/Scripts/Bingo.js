$(document).ready(function () {

	$(".fkup").click(function () {
		$cell = $(this);
		if ($cell.hasClass('black')) {
			$cell.removeClass('black');
			$cellid = $cell.attr('id').substr(4);
			$('#yesno' + $cellid).val('no');
		}
		else {
			$cell.addClass('black');
			$cellid = $cell.attr('id').substr(4);
			$('#yesno' + $cellid).val('yes');

		}
	});

});