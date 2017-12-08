@ModelType QuizLomprayah2.MultipleChoices
@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<div>
    <h4>MultipleChoices</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.MultipleChoices_Question)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.MultipleChoices_Question)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice1)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Multiple_Choice1)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice2)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Multiple_Choice2)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice3)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Multiple_Choice3)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Multiple_Choice4)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Multiple_Choice4)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Multiple_Answer)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Multiple_Answer)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.Multiple_ExamDate)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.Multiple_ExamDate)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.book.subject_code)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.book.subject_code)
        </dd>

    </dl>
    @Using (Html.BeginForm())
        @Html.AntiForgeryToken()

        @<div class="form-actions no-color">
            <input type="submit" value="Delete" class="btn btn-default" /> |
            @Html.ActionLink("Back to List", "Index")
        </div>
    End Using
</div>
