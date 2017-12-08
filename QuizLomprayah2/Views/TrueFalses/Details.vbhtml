@ModelType QuizLomprayah2.TrueFalse
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>TrueFalse</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Question)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TrueFalse_Question)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Choice1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TrueFalse_Choice1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Choice)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TrueFalse_Choice)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_Answer)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TrueFalse_Answer)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TrueFalse_ExamDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TrueFalse_ExamDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book.subject_code)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.TrueFalse_id }) |
    @Html.ActionLink("Back to List", "Index")
</p>
