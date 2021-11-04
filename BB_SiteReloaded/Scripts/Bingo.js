/*
 * This is a script that changes the color of a cell when it gets clicked on.
 * If you're reading this and you're not performing site maintenance, then wtf are you doing with your life? You should also tell Lord your answer to this question.
 */
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